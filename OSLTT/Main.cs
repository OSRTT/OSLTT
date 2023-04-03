using AutoUpdaterDotNET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    public partial class Main : Form
    {
        private string softwareVersion = "0.1";
        private static double boardFirmware = 0.1;

        public static System.IO.Ports.SerialPort port;
        public static bool portConnected = false;

        private ResourceManager rm = OSLTT.Properties.Resources.ResourceManager;

        public class Displays
        {
            public string Name { get; set; }
            public int Freq { get; set; }
            public string Resolution { get; set; }
            public string Connection { get; set; }
            public string ManufacturerCode { get; set; }
            public string EDIDModel { get; set; }
        }
        public List<Displays> displayList = new List<Displays>();

        private Thread readThread = null;
        private Thread connectThread = null;
        private BackgroundWorker bgWorker = new BackgroundWorker();

        string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
        string resultsFolderPath = "";

        private List<float> inputLagEvents = new List<float>();

        private readonly string fqbn = "Seeduino:samd:seeed_XIAO_m0";

        public Main()
        {
            InitializeComponent();

            this.Resize += Form1_Resize;

            path = new Uri(System.IO.Path.GetDirectoryName(path)).LocalPath;
            path += @"\Results";
            UpdateHandler.UpdateMe(softwareVersion);
            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(CFuncs.IFailedYou);
            CFuncs.checkFolderPermissions(path);

            UserSettings.readAndSaveUserSettings(false);

            SetDeviceStatus(0);
            ControlDeviceButtons(false);

            connectThread = new Thread(new ThreadStart(this.findAndConnectToBoard));
            connectThread.Start();

             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When form is closed halt read thread & close Serial Port
            if (port != null)
            {
                try
                {
                    port.Write("X");
                }
                catch { Console.WriteLine("Port not open"); }
            }
            if (connectThread != null)
            {
                connectThread.Abort();
            }
            if (readThread != null)
            {
                readThread.Abort();
            }
            if (port != null)
            {
                port.Close();
            }
            UserSettings.readAndSaveUserSettings(true);
            Environment.Exit(Environment.ExitCode);
        }


        private void findAndConnectToBoard()
        {
            Thread.Sleep(1000);
            bool checkedRunning = false;
            while (true)
            {
                if (!portConnected)
                {
                    ControlDeviceButtons(false);
                    SetDeviceStatus(0);
                    portConnected = false;
                    if (this.fwLbl.IsHandleCreated)
                    {
                        this.fwLbl.Invoke((MethodInvoker)(() => this.fwLbl.Text = "N/A"));
                    }

                    if (!Properties.Settings.Default.updateInProgress)
                    {
                        if (!checkedRunning)
                        {
                            CFuncs.appRunning();
                            checkedRunning = true;
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.updateInProgress = false;
                        Properties.Settings.Default.Save();
                    }
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe board list";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    string[] lines = output.Split(
                        new[] { "\r\n", "\r", "\n" },
                        StringSplitOptions.None
                    );
                    string p = "";
                    foreach (var s in lines)
                    {
                        if (s.Contains(fqbn))
                        {
                            char[] whitespace = new char[] { ' ', '\t' };
                            string[] split = s.Split(whitespace);
                            p = split[0];
                        }
                    }
                    if (p != "")
                    {
                        try
                        {
                            connectToBoard(p, port, readThread, bgWorker);
                            Thread.Sleep(1000);
                            SetDeviceStatus(1);
                            ControlDeviceButtons(true);
                            //setBoardSerial();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            //SetText(e.Message + e.StackTrace);
                        }
                    }

                    Thread.Sleep(1000);

                }
            }
        }

        private void connectToBoard(string comPort, SerialPort port, Thread Read, BackgroundWorker hardWorker)
        {
            System.ComponentModel.IContainer components =
                new System.ComponentModel.Container();
            port = new System.IO.Ports.SerialPort(components);
            port.PortName = comPort;
            port.BaudRate = 115200;
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 5000;
            port.ReadBufferSize = 1048576;
            Console.WriteLine("Port details set");
            try
            { port.Open(); }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            if (port.IsOpen)
            {
                portConnected = true;
                readThread = new Thread(new ThreadStart(this.Read));
                readThread.Start();
                hardWorker.RunWorkerAsync();
                //port.Write("X");
                //Thread.Sleep(250);
                port.Write("I");

            }
            else
            {
                SetDeviceStatus(0);
                ControlDeviceButtons(false);
            }
        }


        public void Read()
        {
            while (port.IsOpen)
            { /*
                try
                {
                    string message = port.ReadLine();
                    if (liveView)
                    {
                        if (message.Contains("pot"))
                        {
                            // update sensitivity
                        }
                        else if (message.Contains("LIVE VIEW"))
                        {
                            // catch this so it doesn't wreck the rest
                        }
                        else if (message.Contains("End"))
                        {

                        }
                        else if (message.Contains("LiveData:"))
                        {
                            string newMessage = message.Remove(0, 9);
                            // send to live view window
                            string[] splitMessage = newMessage.Split(',');
                            List<LiveView.LiveData> dataList = new List<LiveView.LiveData>();
                            foreach (string s in splitMessage)
                            {
                                if (s.Contains(":"))
                                {
                                    string[] stringArr = s.Split(':');
                                    double t = double.Parse(stringArr[0]);
                                    LiveView.LiveData d = new LiveView.LiveData
                                    {
                                        time = t / 1000,
                                        result = double.Parse(stringArr[1])
                                    };
                                    LiveViewObject.addData(d);
                                }
                            }
                            Thread.Sleep(5);
                            LiveViewObject.copyListToArray();
                            LiveViewObject.renderGraph();
                            LiveViewObject.startStopBtn_Click(null, null);

                        }
                    }
                    Console.WriteLine(message);
                    if (debugMode)
                    {
                        SetText(message);
                    }
                    if (message.Contains("Results"))
                    {
                        // Split result string into individual results
                        String newMessage = message.Remove(0, 9);
                        string[] values = newMessage.Split(',');
                        int[] intValues = new int[values.Length - 1];
                        for (int i = 0; i < values.Length - 1; i++)
                        {
                            if (values[i] == "0")
                            {
                                intValues[i] = 0;
                            }
                            else if (values[i] != "")
                            {
                                try
                                {
                                    intValues[i] = int.Parse(values[i]);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(values[i]);
                                }
                            }
                            else { continue; }
                        }
                        // Added extra check to make sure test is cancelled if there isn't a light level difference between start and end. Using 5 samples to account for noise.
                        int start = intValues[50] + intValues[51] + intValues[52] + intValues[53] + intValues[54];
                        int end = intValues[intValues.Length - 50] + intValues[intValues.Length - 51] + intValues[intValues.Length - 52] + intValues[intValues.Length - 53] + intValues[intValues.Length - 54];
                        if (intValues[0] < intValues[1])
                        {
                            if (start < end)
                            {
                                ProcessData.rawResultData rawResult = new ProcessData.rawResultData
                                {
                                    StartingRGB = intValues[0],
                                    EndRGB = intValues[1],
                                    TimeTaken = intValues[2],
                                    SampleCount = intValues[3],
                                    SampleTime = ((double)intValues[2] / (double)intValues[3]),
                                    Samples = intValues.Skip(4).ToList()
                                };
                                results[currentRun].Add(rawResult);
                            }
                            else
                            {
                                if (!Properties.Settings.Default.ignoreErrors)
                                {
                                    port.Write("X");
                                    port.Write("X");
                                    port.Write("X");
                                    testRunning = false;
                                    if (runTestThread != null)
                                    {
                                        runTestThread.Abort();
                                    }
                                    MessageBox.Show("The last test result showed no difference in light level. The brightness may be too high. The test has been cancelled.", "Test Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    ProcessData.rawResultData rawResult = new ProcessData.rawResultData
                                    {
                                        StartingRGB = intValues[0],
                                        EndRGB = intValues[1],
                                        TimeTaken = intValues[2],
                                        SampleCount = intValues[3],
                                        SampleTime = ((double)intValues[2] / (double)intValues[3]),
                                        Samples = intValues.Skip(4).ToList()
                                    };
                                    results[currentRun].Add(rawResult);
                                }
                            }
                        }
                        else
                        {
                            if (start > end)
                            {
                                ProcessData.rawResultData rawResult = new ProcessData.rawResultData
                                {
                                    StartingRGB = intValues[0],
                                    EndRGB = intValues[1],
                                    TimeTaken = intValues[2],
                                    SampleCount = intValues[3],
                                    SampleTime = ((double)intValues[2] / (double)intValues[3]),
                                    Samples = intValues.Skip(4).ToList()
                                };
                                results[currentRun].Add(rawResult);
                            }
                            else
                            {
                                if (!Properties.Settings.Default.ignoreErrors)
                                {
                                    port.Write("X");
                                    port.Write("X");
                                    port.Write("X");
                                    testRunning = false;
                                    if (runTestThread != null)
                                    {
                                        runTestThread.Abort();
                                    }
                                    MessageBox.Show("The last test result showed no difference in light level. The brightness may be too high. The test has been cancelled.", "Test Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    ProcessData.rawResultData rawResult = new ProcessData.rawResultData
                                    {
                                        StartingRGB = intValues[0],
                                        EndRGB = intValues[1],
                                        TimeTaken = intValues[2],
                                        SampleCount = intValues[3],
                                        SampleTime = ((double)intValues[2] / (double)intValues[3]),
                                        Samples = intValues.Skip(4).ToList()
                                    };
                                    results[currentRun].Add(rawResult);
                                }
                            }
                        }

                        currentStart = intValues[0];
                        currentEnd = intValues[1];

                    }

                    else if (message.Contains("Test Started"))
                    {
                        testStarted = true;
                    }
                    else if (message.Contains("NEXT"))
                    {
                        triggerNextResult = true;
                        //Console.WriteLine("trigger next result true");
                    }
                    else if (message.Contains("FW:"))
                    {
                        string[] sp = message.Split(':');
                        boardFirmware = double.Parse(sp[1]);
                        compareFirmware();
                        this.fwLbl.Invoke((MethodInvoker)(() => this.fwLbl.Text = "V" + boardFirmware));
                    }
                    else if (message.Contains("TEST CANCELLED"))
                    {
                        testRunning = false;
                        testMode = false;
                        if (message.Contains("LIGHT LEVEL"))
                        {
                            MessageBox.Show("ERROR - TEST CANCELLED. Monitor's brightness may not be in the acceptable range.", "Test Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            brightnessCheck = false;
                        }
                        else if (message.Contains("USB VOLTAGE"))
                        {
                            MessageBox.Show("ERROR - TEST CANCELLED. USB supply voltage may be too low - please plug the device either directly into your system or a powered USB hub.", "Test Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (message.Contains("Ready to test"))
                    {
                        testMode = true;
                    }
                    else if (message.Contains("UniqueID"))
                    {
                        string s = message.Remove(0, 9);
                        Regex.Replace(s, @"\s+", "");
                        Properties.Settings.Default.serialNumber = s;
                        Properties.Settings.Default.Save();
                    }
                    else if (message.Contains("IL"))
                    {
                        if (message.Contains("IL:"))
                        {
                            // Results Data
                            String newMessage = message.Remove(0, 3);
                            string[] values = newMessage.Split(',');
                            List<int> intValues = new List<int>();
                            for (int i = 0; i < values.Length - 1; i++)
                            {
                                if (values[i] == "0")
                                {
                                    intValues.Add(0);
                                }
                                else if (values[i] != "")
                                {
                                    try
                                    {
                                        intValues.Add(int.Parse(values[i]));
                                    }
                                    catch
                                    {
                                        Console.WriteLine(values[i]);
                                    }
                                }
                                else { continue; }
                            }
                            if (DirectX.System.DSystem.EventList.Count == 0)
                            { Thread.Sleep(50); } // add continuous check
                            float frameTime = 0;
                            try
                            {
                                frameTime = DirectX.System.DSystem.EventList.Last();
                            }
                            catch
                            { }

                            ProcessData.rawInputLagResult rawLag = new ProcessData.rawInputLagResult
                            {
                                ClickTime = intValues[0],
                                TimeTaken = intValues[1],
                                SampleCount = intValues[2],
                                SampleTime = (double)intValues[1] / (double)intValues[2],
                                Samples = intValues.Skip(4).ToList(),
                                FrameTime = frameTime
                            };
                            inputLagRawData.Add(rawLag);
                        }
                        else if (message.Contains("Clicks"))
                        {
                            // Send number of clicks to run
                            int clicks = numberOfClicks / 10;
                            Console.WriteLine("Clicks: " + clicks);
                            port.Write(clicks.ToString("00"));
                        }
                        else if (message.Contains("Time"))
                        {
                            // Send time between setting
                            double t = timeBetween * 10;
                            port.Write(t.ToString());
                            Console.WriteLine("Time Between: " + t);
                        }
                        else if (message.Contains("Finished"))
                        {
                            if (Properties.Settings.Default.saveInputLagRaw)
                            {
                                string[] folders = resultsFolderPath.Split('\\');
                                string monitorInfo = folders.Last();
                                string filePath = resultsFolderPath + "\\" + monitorInfo + "-INPUT-LATENCY-RAW.csv";
                                /*
                                decimal fileNumber = 001;
                                // search /Results folder for existing file names, pick new name
                                string[] existingFiles = Directory.GetFiles(resultsFolderPath, "*-INPUT-LAG-RAW-OSRTT.csv");
                                //search files for number
                                foreach (var s in existingFiles)
                                {
                                    decimal num = decimal.Parse(Path.GetFileNameWithoutExtension(s).Remove(3));
                                    if (num >= fileNumber)
                                    {
                                        fileNumber = num + 1;
                                    }
                                }

                                string filePath = resultsFolderPath + "\\" + fileNumber.ToString("000") + "-INPUT-LAG-RAW-OSRTT.csv";
                                
                                string strSeparator = ",";
                                StringBuilder csvString = new StringBuilder();
                                foreach (var res in inputLagRawData)
                                {
                                    csvString.AppendLine(res.ClickTime.ToString() + "," + res.FrameTime.ToString() + "," + res.TimeTaken.ToString() + "," + res.SampleCount.ToString() + "," + string.Join(strSeparator, res.Samples));
                                }
                                File.WriteAllText(filePath, csvString.ToString());
                            }
                            Thread inputLagThread = new Thread(new ThreadStart(processInputLagData));
                            inputLagThread.Start();
                            //processInputLagData();
                        }
                    }

                    else
                    {
                        this.SetText(message);
                    }
                }
                catch (TimeoutException ex)
                {
                    //Console.WriteLine(ex);
                    //SetText(ex.Message + ex.StackTrace);
                }
                catch (ArgumentOutOfRangeException aex)
                {
                    Console.WriteLine(aex);
                    SetText(aex.Message + aex.StackTrace);
                }
                catch (Exception e)
                {
                    try
                    {
                        port.Write("X");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                        SetText(exc.Message + exc.StackTrace);
                    }
                    Console.WriteLine(e);
                    SetText(e.Message + e.StackTrace);
                    port.Close();
                    portConnected = false;
                    testRunning = false;
                    testMode = false;
                    testStarted = false;
                    brightnessCheck = false;
                    if (runTestThread != null)
                    { runTestThread.Abort(); }
                    readThread.Abort();
                }*/
            }
        }

        private void ControlDeviceButtons(bool state)
        {
            /*if (this.launchBtn.InvokeRequired)
            {
                this.launchBtn.Invoke((MethodInvoker)(() => launchBtn.Enabled = state));
                this.menuStrip1.Invoke((MethodInvoker)(() => BrightnessCalBtn.Visible = state));
                this.inputLagButton.Invoke((MethodInvoker)(() => inputLagButton.Enabled = state));
                this.LiveViewBtn.Invoke((MethodInvoker)(() => LiveViewBtn.Enabled = state));
            }
            else
            {
                this.launchBtn.Enabled = state;
                this.BrightnessCalBtn.Visible = state;
                this.inputLagButton.Enabled = state;
                this.LiveViewBtn.Enabled = state;
            }*/
        }

        private void SetDeviceStatus(int state)
        {
            string text = " Device Not Connected";
            Color bg = Color.FromArgb(255, 255, 131, 21);
            Color btnBg = Color.Gray;
            bool active = false;
            bool check = false;
            if (state == 1)
            {
                text = "Device Connected";
                bg = Color.White;
                check = true;
                active = true;
                btnBg = Color.FromArgb(255, 105, 180, 76);
            }
            else if (state == 2)
            {
                text = "Updating Firmware Now";
                bg = Color.Violet;
            }
            else if (state == 3)
            {
                text = "Update Successful";
                bg = Color.FromArgb(255, 105, 180, 76);
                check = true;
            }
            else if (state == 4)
            {
                text = "Firmware Update Failed";
                bg = Color.FromArgb(255, 255, 80, 80);
            }
            if (this.devStat.InvokeRequired)
            {
                this.devStat.Invoke((MethodInvoker)(() => this.devStat.Text = text));
                this.checkImg.Invoke((MethodInvoker)(() => this.checkImg.Visible = check));
                this.fwLblTitle.Invoke((MethodInvoker)(() => this.fwLblTitle.Visible = check));
                this.fwLbl.Invoke((MethodInvoker)(() => this.fwLbl.Visible = check));
                this.deviceStatusPanel.Invoke((MethodInvoker)(() => this.deviceStatusPanel.BackColor = bg));
                //this.controlsPanel.Invoke((MethodInvoker)(() => this.controlsPanel.Enabled = active));
                /*this.launchBtn.Invoke((MethodInvoker)(() => this.launchBtn.Enabled = active));
                this.fpsLimitList.Invoke((MethodInvoker)(() => this.fpsLimitList.Enabled = active));
                this.testCount.Invoke((MethodInvoker)(() => this.testCount.Enabled = active));
                this.captureTimeBox.Invoke((MethodInvoker)(() => this.captureTimeBox.Enabled = active));
                this.vsyncStateList.Invoke((MethodInvoker)(() => this.vsyncStateList.Enabled = active));
                this.inputLagPanel.Invoke((MethodInvoker)(() => this.inputLagPanel.Enabled = active));
                this.launchBtn.Invoke((MethodInvoker)(() => this.launchBtn.BackColor = btnBg));
                this.inputLagButton.Invoke((MethodInvoker)(() => this.inputLagButton.BackColor = btnBg));
                this.LiveViewBtn.Invoke((MethodInvoker)(() => LiveViewBtn.Enabled = active));
                this.LiveViewBtn.Invoke((MethodInvoker)(() => LiveViewBtn.BackColor = btnBg));*/
            }
            else
            {
                this.devStat.Text = text;
                this.checkImg.Visible = check;
                this.deviceStatusPanel.BackColor = bg;
                this.fwLblTitle.Visible = check;
                this.fwLbl.Visible = check;
                //this.controlsPanel.Enabled = active;
                /*this.launchBtn.Enabled = active;
                this.fpsLimitList.Enabled = active;
                this.testCount.Enabled = active;
                this.captureTimeBox.Enabled = active;
                this.vsyncStateList.Enabled = active;
                this.inputLagPanel.Enabled = active;
                this.launchBtn.BackColor = btnBg;
                this.inputLagButton.BackColor = btnBg;
                this.LiveViewBtn.Enabled = active;
                this.LiveViewBtn.BackColor = btnBg;
                */
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,Color.LightBlue,Color.SteelBlue,120F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        

        public void getInputLagEvents(List<float> fpsList)
        {
            inputLagEvents = fpsList;
            //Console.WriteLine(fpsList.Average().ToString());
        }
    }
}
