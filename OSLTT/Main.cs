﻿using AutoUpdaterDotNET;
using GlobalHotKey;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using SharpDX.Multimedia;
using SharpDX.XAudio2;
using static OSLTT.ProcessData;

namespace OSLTT
{
    public partial class Main : MaterialForm
    {
        private string softwareVersion = "1.7";
        private static double boardFirmware = 0;
        private static double downloadedFirmwareVersion = -1;
        public static int boardType = Properties.Settings.Default.LastBoardType;

        public static System.IO.Ports.SerialPort port;
        public static bool portConnected = false;
        public static bool fwUpdateRunning = false;
        public static bool boardUpdate = false;

        private ResourceManager rm = OSLTT.Properties.Resources.ResourceManager;

        public TestSettings testSettings = new TestSettings();

        private Thread readThread = null;
        private Thread connectThread = null;
        private BackgroundWorker bgWorker = new BackgroundWorker();

        string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
        string resultsPath = "";
        string resultsFolderPath = "";
        string rawFileName = "";
        string processedFileName = "";

        private List<float> inputLagEvents = new List<float>();
        private List<rawInputLagResult> inputLagRawData = new List<rawInputLagResult>();
        private List<inputLagResult> inputLagProcessed = new List<inputLagResult>();
        private List<rawInputLagResult> rawSystemLagData = new List<rawInputLagResult>();
        public averagedInputLag systemLagData = new averagedInputLag();

        public SettingsClasses.RunSettings RunSettings;
        private bool processingFailed = false;
        public bool settingsSynced = false;

        HotKeyManager hotKeys = new HotKeyManager();
        List<HotKey> hotKeyList = new List<HotKey>();
        MouseHook mouseHook = new MouseHook();
        KeyboardHook keyboardHook = new KeyboardHook();

        private readonly string fqbn = "Seeeduino:samd:seeed_XIAO_m0";
        private readonly string fqbn2 = "adafruit:samd:adafruit_feather_m0";

        debugForm debug = new debugForm();

        SoundPlayer audioTestClip;

        public bool MouseMoveTest = false;

        Stopwatch sw = new Stopwatch();
        List<List<long>> testList = new List<List<long>>();
        int testLoopCounter = 0;
        public Main()
        {
            this.Icon = (Icon)rm.GetObject("icon");
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            appRunning();

            //982, 588
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.Resize += Form1_Resize;

            path = new Uri(System.IO.Path.GetDirectoryName(path)).LocalPath;
            resultsPath = path + @"\Results";
            if (!Directory.Exists(resultsPath)) { Directory.CreateDirectory(resultsPath); }

            audioTestClip = new SoundPlayer(Properties.Resources.OSLTTTone);

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

            settingsPane1.mainWindow = this;
            SetDeviceStatus(0);
            toggleMouseKeyboardBoxes(false);
            fillHotkeyList();
            UpdateFirmware.initialSetup();
            downloadedFirmwareVersion = UpdateFirmware.getNewFirmwareFile(path);

            connectThread = new Thread(new ThreadStart(this.findAndConnectToBoard));
            connectThread.Start();

            CleanupDevTools();
            debug.mainWindow = this;

            UpdateHandler.AnnouncementText announcementText = UpdateHandler.GetAnnouncements(path);
            if (announcementText != null)
            {
                Announcements announcements = new Announcements();
                announcements.SetAnnouncement(announcementText);
                announcements.Show();
                announcements.Activate();
                //ActiveControl = announcements;
            }
            this.Text += softwareVersion;
            sw.Start();
            UpdateHandler.UpdateMe(softwareVersion);
        }

        /// <summary>
        /// Hide dev test button if debugger is attached
        /// </summary>
        private void CleanupDevTools()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                materialButton1.Visible = true;
                materialButton1.Location = new Point(418, 2);
                materialButton2.Visible = true;
                materialButton2.Location = new Point(260, 2);
            }
            else
            {
                materialButton1.Visible = false;
                materialButton1.Location = new Point(418, -50);
                materialButton2.Visible = false;
                materialButton2.Location = new Point(260, -50);
            }
        }

        /// <summary>
        /// Checks if there's another instance of the program running
        /// </summary>
        private void appRunning()
        {
            Process[] p = Process.GetProcessesByName("OSLTT");
            if (p.Length > 1)
            {
                MessageBox.Show("ERROR: Program already open! Please close it before running again, or check the task bar and system tray for the running app.", "Program Open Already", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(p.Length);
                //this.Close();
            }
        }

        /// <summary>
        /// Init hotkeys - specifically F10 for now.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            hotKeys.KeyPressed += HotKeyPressed;
            try
            {
                var k = hotKeys.Register(hotkeysDict[Properties.Settings.Default.hotkey], System.Windows.Input.ModifierKeys.None);
                hotKeyList.Add(k);
            }
            catch (Exception ex)
            {
                CFuncs.showMessageBox("Error Registering Hotkey",
                    "Error: Unable to register hotkey. Please pick a different key not already in use.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }

            mouseHook.LeftButtonDown += MouseHook_LeftButtonDown;
            mouseHook.MouseMove += MouseHook_Move;
            keyboardHook.KeyDown += KeyboardHook_KeyDown;
        }

        private void KeyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            if (!MouseMoveTest)
            {
                portWrite("H");
                Console.WriteLine(key.ToString());
            }
            else if (!MouseMoveReady)
            {
                portWrite("R");
                MouseMoveReady = true;
            }
        }

        /// <summary>
        /// MouseHook left click event handler - used for click/keypress test
        /// </summary>
        /// <param name="mouseStruct"></param>
        private void MouseHook_LeftButtonDown(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (testSettings.TestSource == 2)
            {
                portWrite("H");
                Console.WriteLine("Triggered");
            }
            else
            {
                MouseMoveReady = true;
            }
        }

        private bool MouseMoveReady = true;
        /// <summary>
        /// MouseHook move event handler - used for click/keypress test
        /// </summary>
        /// <param name="mouseStruct"></param>
        private void MouseHook_Move(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if (MouseMoveReady)
            {
                portWrite("H");
                Console.WriteLine("Triggered");
                MouseMoveReady = false;
            }
        }

        private bool ControllerKill = false;
        private GamepadButtonFlags lastButton;
        /// <summary>
        /// Controller handler
        /// </summary>
        private void ControllerEventHandler()
        {
            Console.WriteLine("Controller starting");
            Controller c = new Controller(UserIndex.One);
            if (c.IsConnected == false)
            {
                Console.WriteLine("Controller not found");
                CFuncs.showMessageBox("Controller Not Found", "Unable to connect to controller, please connect one and start the test again.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var previousState = c.GetState();
                while (c.IsConnected)
                {
                    if (ControllerKill == true)
                    {
                        break;
                    }
                    var state = c.GetState();
                    if (previousState.PacketNumber != state.PacketNumber)
                    {
                        if (state.Gamepad.Buttons != GamepadButtonFlags.None && state.Gamepad.Buttons != lastButton)
                        {
                            lastButton = state.Gamepad.Buttons;
                            portWrite("H");
                            Console.WriteLine(state.Gamepad);
                            Thread.Sleep(100);
                        }
                    }
                    Thread.Sleep(1);
                    previousState = state;
                }
            }
            Console.WriteLine("Exiting controller handler");
        }

        static void PlaySoundFile(XAudio2 device)
        {
            var stream = new SoundStream(Properties.Resources.OSLTTTone);
            var waveFormat = stream.Format;
            var buffer = new AudioBuffer
            {
                Stream = stream.ToDataStream(),
                AudioBytes = (int)stream.Length,
                Flags = BufferFlags.EndOfStream
            };
            stream.Close();
            var sourceVoice = new SourceVoice(device, waveFormat, true);
            sourceVoice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);
            sourceVoice.Start();
            while (sourceVoice.State.BuffersQueued > 0)
            {
                Thread.Sleep(10);
            }
            Console.WriteLine();
            sourceVoice.DestroyVoice();
            sourceVoice.Dispose();
            buffer.Stream.Dispose();
        }

        /// <summary>
        /// Handle when the form closes to cancel any running tests and save settings to file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When form is closed halt read thread & close Serial Port
            ControllerKill = true;
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

        #region Serial Connection
        /// <summary>
        /// Function to use the arduino cli to find the board and initiate connect over serial. Also handles the update connection.
        /// </summary>
        private void findAndConnectToBoard()
        {
            Thread.Sleep(1000);
            bool checkedRunning = false;
            while (true)
            {
                if (!portConnected)
                {
                    SetDeviceStatus(0);
                    portConnected = false;
                    try
                    {
                        //testThread.Abort();
                    }
                    catch { }
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
                    string board = "";
                    foreach (var s in lines)
                    {
                        if (s.Contains(fqbn) || s.Contains(fqbn2))
                        {
                            char[] whitespace = new char[] { ' ', '\t' };
                            string[] split = s.Split(whitespace);
                            p = split[0];
                            board = s;
                        }
                    }
                    if (p != "")
                    {
                        try
                        {
                            connectToBoard(p);
                            Thread.Sleep(1000);
                            SetDeviceStatus(1);
                            if (board.Contains("feather")) { 
                                settingsPane1.CheckBoardType(1);
                                boardType = 1;
                                Properties.Settings.Default.LastBoardType = 1;
                            }
                            else { 
                                settingsPane1.CheckBoardType();
                                boardType = 0;
                                Properties.Settings.Default.LastBoardType = 0;
                            }
                            Thread syncThread = new Thread(new ThreadStart(SyncSettingsThreadFunc));
                            syncThread.Start();
                            Properties.Settings.Default.Save();
                            //setBoardSerial();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            debug.AddToLog(e.Message + e.StackTrace);
                        }
                    }
                    Thread.Sleep(1000);
                }
                else if (fwUpdateRunning) // probably don't need this anymore
                {
                    Thread.Sleep(100);
                }
                else if (boardUpdate)
                {
                    fwUpdateRunning = true;
                    SetDeviceStatus(2);
                    string p = "";
                    p = port.PortName;
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
                    if (p == "")
                    {
                        MessageBox.Show("Please connect to the device first!", "Update Device", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UpdateFirmware.FirmwareReport fw = UpdateFirmware.UpdateDeviceFirmware(path, p, boardType);
                        SetDeviceStatus(fw.State);
                        debug.AddToLog(fw.ErrorMessage);
                        if (fw.State == 4)
                        {
                            CFuncs.showMessageBox("Firmware update failed", fw.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (fw.State == 3)
                        {
                            if (port.IsOpen)
                            {
                                port.Close();
                            }
                        }
                    }
                    fwUpdateRunning = false;
                    boardUpdate = false;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Takes in the COM port name from findAndConnectToBoard and initiates the serial connection
        /// </summary>
        /// <param name="comPort"></param>
        private void connectToBoard(string comPort)
        {
            System.ComponentModel.IContainer components =
                new System.ComponentModel.Container();
            port = new System.IO.Ports.SerialPort(components);
            port.PortName = comPort;
            port.BaudRate = 115200;
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 5000;
            port.ReadBufferSize = 2097152;
            Console.WriteLine("Port details set");
            try
            { port.Open(); }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            if (port.IsOpen)
            {
                portConnected = true;
                Thread.Sleep(100);
                port.Write("I");
                readThread = new Thread(new ThreadStart(this.Read));
                readThread.Start();
                bgWorker.RunWorkerAsync();
                //port.Write("X");
                //Thread.Sleep(250);

            }
            else
            {
                SetDeviceStatus(0);
            }
        }
        #endregion

        #region Serial Read
        /// <summary>
        /// This function endlessly reads the serial bus waiting for output from the device.
        /// </summary>
        public void Read()
        {
            while (port.IsOpen)
            {
                try
                {
                    string message = port.ReadLine();
                    Console.WriteLine(message);
                    /*if (liveView)
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
                    }*/
                    /*if (debugMode)
                    {
                        debug.AddToLog(message);
                    }*/
                    if (message.Contains("RESULT:"))
                    {
                        // on-device processed result. not that accurate.
                    }
                    else if (message.Contains("Settings Synced"))
                    {
                        settingsSynced = true;
                    }
                    else if (message.Contains("AUDIO TRIGGER"))
                    {
                        // play sound
                        audioTestClip.Play();
                    }
                    else if (message.Contains("FW:"))
                    {
                        string[] sp = message.Split(':');
                        boardFirmware = double.Parse(sp[1]);
                        compareFirmware();
                        this.fwLbl.Invoke((MethodInvoker)(() => this.fwLbl.Text = "V" + boardFirmware));
                    }
                    /*
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
                    }*/
                    else if (message.Contains("Ready to test"))
                    {
                        //testMode = true;
                    }
                    else if (message.Contains("UniqueID"))
                    {
                        string s = message.Remove(0, 9);
                        Regex.Replace(s, @"\s+", "");
                        //Properties.Settings.Default.serialNumber = s;
                        //Properties.Settings.Default.Save();
                    }
                    else if (message.Contains("RES:"))
                    {

                        // Results Data
                        resultType type = resultType.Light;
                        if (message.Contains("AUDIO"))
                        {
                            type = resultType.Audio;
                        }
                        string[] newMessage = message.Split(':');
                        string[] values = newMessage[1].Split(',');
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
                        float frameTime = 0;
                        if (testSettings.TestSource == 1)
                        {
                            if (DirectX.System.DSystem.EventList.Count == 0)
                            { Thread.Sleep(50); } // add continuous check
                            try
                            {
                                frameTime = DirectX.System.DSystem.EventList.Last();
                            }
                            catch
                            { }
                        }
                        else if (testSettings.TestSource == 3 && systemLagData.onDisplayLatency != null)
                        {
                            frameTime = (float)systemLagData.onDisplayLatency.AVG;
                        }

                        rawInputLagResult rawLag = new rawInputLagResult
                        {
                            ResultType = type,
                            ClickTime = intValues[0],
                            TimeTaken = intValues[1],
                            SampleCount = intValues[2],
                            SampleTime = (double)intValues[1] / (double)intValues[2],
                            Samples = intValues.Skip(4).ToList(),
                            FrameTime = frameTime
                        };
                        inputLagRawData.Add(rawLag);
                        // save result to raw file - depricated (for now)
                        //CFuncs.saveRawResultToFile(resultsFolderPath, rawFileName, rawLag);
                        // process individual result


                    }
                    else if (message.Contains("CLICK:"))
                    {
                        // click result
                        string[] splitMessage = message.Split(':');
                        double result = double.Parse(splitMessage[1]);
                        inputLagProcessed.Add(new inputLagResult { Type = resultType.Click, shotNumber = inputLagProcessed.Count + 1, totalInputLag = result / 1000 });
                        lastButton = GamepadButtonFlags.None;
                    }
                    else if (message.Contains("AUTO FINISHED")) // auto click test complete, write to folder & process
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    else if (message.Contains("Clicks Finished")) // click test finished, end test (user cancelled test)
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    else if (message.Contains("AUDIO TEST FINISHED")) // audio test auto click finished
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    else if (message.Contains("PRETEST:"))
                    {
                        // Results Data
                        string newMessage = message.Remove(0, 8);
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
                        float frameTime = 0;

                        if (DirectX.System.DSystem.EventList.Count == 0)
                        { Thread.Sleep(50); } // add continuous check
                        try
                        {
                            frameTime = DirectX.System.DSystem.EventList.Last();
                        }
                        catch
                        { }


                        rawInputLagResult rawLag = new rawInputLagResult
                        {
                            ClickTime = intValues[0],
                            TimeTaken = intValues[1],
                            SampleCount = intValues[2],
                            SampleTime = (double)intValues[1] / (double)intValues[2],
                            Samples = intValues.Skip(4).ToList(),
                            FrameTime = frameTime
                        };
                        rawSystemLagData.Add(rawLag);
                        // save result to raw file
                        //CFuncs.saveRawResultToFile(resultsFolderPath, rawFileName, rawLag);
                        // process individual result


                    }
                    else if (message.Contains("PRETEST FINISHED")) // auto click test complete, write to folder & process
                    {
                        Thread inputLagThread = new Thread(new ThreadStart(processPretestData)); // change to processPretest?
                        inputLagThread.Start();

                    }
                    else if (message.Contains("FINISHED"))
                    {
                        // end test
                        startTestBtn_Click(null, null);
                    }
                    else if (message.Contains("SINGLE FIRE")) // depricated? 
                    {
                        // write most recent result to raw file
                        // process then append processed result to file
                    }
                    else if (message.Contains("CLICKTEST"))
                    {
                        clickTestBox_Click(null, null);
                    }
                    else if (message.Contains("MICTEST:"))
                    {
                        string message2 = message.Remove(0, 8);
                        File.WriteAllText(resultsPath + "\\micdump.csv", message2);
                        debug.AddToLog("Saved Mic Dump Data to " + resultsPath + "\\micdump.csv");
                        if (Debugger.IsAttached)
                        {
                            string[] values = message2.Split(',');
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
                            if (intValues.Max() > 12000)
                            {
                                debug.AddToLog("Problem, check file");
                            }
                        }
                    }
                    else
                    {
                        debug.AddToLog(message);
                    }
                }
                catch (TimeoutException ex) // purposefully catch and ignore serial timeouts
                {
                    //Console.WriteLine(ex);
                    //debug.AddToLog(ex.Message + ex.StackTrace);
                }
                catch (ArgumentOutOfRangeException aex)
                {
                    Console.WriteLine(aex);
                    debug.AddToLog(aex.Message + aex.StackTrace);
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
                        debug.AddToLog(exc.Message + exc.StackTrace);
                    }
                    Console.WriteLine(e);
                    debug.AddToLog(e.Message + e.StackTrace);
                    port.Close();
                    portConnected = false;
                    //testRunning = false;
                    //testMode = false;
                    //testStarted = false;

                    //if (runTestThread != null)
                    //{ runTestThread.Abort(); }
                    //readThread.Abort();
                }
            }
        }
        #endregion

        /// <summary>
        /// Safely write to the serial port
        /// </summary>
        /// <param name="input"></param>
        public void portWrite(string input)
        {
            if (port != null)
            {
                if (port.IsOpen)
                {
                    try
                    {
                        port.Write(input);
                    }
                    catch (Exception ex)
                    {
                        debug.AddToLog(ex.Message + ex.StackTrace);
                        Console.WriteLine(ex.Message + ex.StackTrace);
                    }
                }
            }
        }

        private void compareFirmware()
        {
            // run function to fetch latest version, returns new version number
            // if (boardFirmware < newFirmware)
            // fwUpdateRunning = true;
            // port.Close();
            // run function to update firmware, returns bool. 
            if (downloadedFirmwareVersion > boardFirmware)
            {
                DialogResult d = CFuncs.showMessageBox("Current version: " + boardFirmware.ToString() + "\n New version: " + downloadedFirmwareVersion.ToString() + "\n Update now?", "Firmware Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    boardUpdate = true;
                    port.Close();
                }
            }

        }



        private void SetDeviceStatus(int state)
        {
            string text = " Device Not Connected";
            string testBtnText = "Start";
            Color bg = Color.FromArgb(255, 255, 131, 21);
            Color btnBg = Color.Gray;
            bool active = false;
            bool check = false;
            if (state == 1)
            {
                text = "Device Connected";
                check = true;
                active = true;
                bg = Color.FromArgb(255, 38, 50, 56);
            }
            else if (state == 2)
            {
                text = "Updating Firmware";
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
            else if (state == 5)
            {
                text = "Test Running";
                active = false;
                bg = Color.FromArgb(255, 38, 50, 56);
                testBtnText = "End Test";
                check = true;
            }
            if (systemLagData.inputLagResults != null)
            {
                text += " - Pretest Data Saved";
            }
            if (this.devStat.InvokeRequired)
            {
                this.devStat.Invoke((MethodInvoker)(() => this.devStat.Text = text));
                this.fwLblTitle.Invoke((MethodInvoker)(() => this.fwLblTitle.Visible = check));
                this.fwLbl.Invoke((MethodInvoker)(() => this.fwLbl.Visible = check));
                this.deviceStatusPanel.Invoke((MethodInvoker)(() => this.deviceStatusPanel.BackColor = bg));
                this.startTestBtn.Invoke((MethodInvoker)(() => this.startTestBtn.Text = testBtnText));
                this.startTestBtn.Invoke((MethodInvoker)(() => this.startTestBtn.Enabled = check));
                this.runPretestButton.Invoke((MethodInvoker)(() => this.runPretestButton.Enabled = check));
                this.Invoke((MethodInvoker)(() => this.Invalidate()));
            }
            else
            {
                this.devStat.Text = text;
                this.deviceStatusPanel.BackColor = bg;
                this.fwLblTitle.Visible = check;
                this.fwLbl.Visible = check;
                this.startTestBtn.Text = testBtnText;
                this.startTestBtn.Enabled = check;
                this.runPretestButton.Enabled = check;
                this.Invalidate();
            }
        }

        private void toggleMouseKeyboardBoxes(bool state)
        {
            if (this.clickTestBox.InvokeRequired)
            {
                this.clickTestBox.Invoke((MethodInvoker)(() => this.clickTestBox.Visible = state));
                this.settingsPane1.Invoke((MethodInvoker)(() => this.settingsPane1.Visible = !state));

                if (state)
                {
                    this.clickTestBox.Invoke((MethodInvoker)(() => this.clickTestBox.BringToFront()));
                    this.Invoke((MethodInvoker)(() => this.mouseMoveLabel.Visible = false));
                    if (testSettings.TestSource == 2)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Install()));
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Install()));
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        Thread t = new Thread(new ThreadStart(ControllerEventHandler));
                        t.Start();
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Install()));
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Install()));
                        this.Invoke((MethodInvoker)(() => this.mouseMoveLabel.Visible = true));
                    }
                }
                else
                {
                    if (testSettings.TestSource == 2)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Uninstall()));
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Uninstall()));
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        ControllerKill = true;
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        this.Invoke((MethodInvoker)(() => this.mouseHook.Uninstall()));
                        this.Invoke((MethodInvoker)(() => this.keyboardHook.Uninstall()));
                        this.Invoke((MethodInvoker)(() => this.mouseMoveLabel.Visible = false));
                    }
                }
            }
            else
            {
                this.clickTestBox.Visible = state;
                this.settingsPane1.Visible = !state;
                if (state)
                {
                    this.clickTestBox.BringToFront();
                    mouseMoveLabel.Visible = false;
                    if (testSettings.TestSource == 2)
                    {
                        mouseHook.Install();
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        keyboardHook.Install();
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        Thread t = new Thread(new ThreadStart(ControllerEventHandler));
                        t.Start();
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        mouseHook.Install();
                        keyboardHook.Install();
                        mouseMoveLabel.Visible = true;
                    }

                }
                else
                {
                    if (testSettings.TestSource == 2)
                    {
                        mouseHook.Uninstall();
                        //Console.WriteLine("(invoke) Mousehook installed");
                    }
                    else if (testSettings.TestSource == 6)
                    {
                        keyboardHook.Uninstall();
                    }
                    else if (testSettings.TestSource == 7)
                    {
                        ControllerKill = true;
                    }
                    else if (testSettings.TestSource == 8)
                    {
                        mouseHook.Uninstall();
                        keyboardHook.Uninstall();
                        mouseMoveLabel.Visible = false;
                    }
                }
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

        private DialogResult DialogBox(string message, string title, string okButton, bool showCancel, string cancelText = "Cancel")
        {
            try
            {
                MaterialDialog materialDialog = new MaterialDialog(this, title, message, okButton, showCancel, cancelText, true);
                DialogResult result = materialDialog.ShowDialog(this);
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar(result.ToString(), 750);

                SnackBarMessage.Show(this);
                return result;
            }
            catch (InvalidOperationException ex)
            {
                DialogResult d = MessageBox.Show(message, title, MessageBoxButtons.OKCancel);
                return d;
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            CFuncs.HyperlinkOut("https://OSRTT.github.io/OSLTTDocs/");
        }

        private void debugBtn_Click(object sender, EventArgs e)
        {
            if (debug.IsDisposed)
            {
                debug = new debugForm();
                debug.mainWindow = this;
            }
            debug.Show();
        }

        private void HotKeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.HotKey.Key == hotKeyList[0].Key)
            {
                if (startTestBtn.Enabled)
                {
                    startTestBtn_Click(null, null);
                }
                else
                {
                    // message box to say can't start test? undecided.
                    Console.WriteLine("Didn't start test");
                }
            }
        }

        private void runPretestButton_Click(object sender, EventArgs e)
        {
            runPretest();
            pretestButtonState();
        }

        public void pretestButtonState()
        {
            if (systemLagData.inputLagResults != null)
            {
                SetDeviceStatus(1);
                runPretestButton.Enabled = false;
            }
            else
            {
                SetDeviceStatus(1);
                runPretestButton.Enabled = true;
            }
        }

        private Thread testThread;
        public bool stopTest = false;

        private void startTestBtn_Click(object sender, EventArgs e)
        {
            if (startTestBtn.Text == "Start")
            {
                bool skipTest = false; // can't think of a better way to do this atm..
                if (testSettings.PreTest && systemLagData.inputLagResults == null)
                {
                    DialogResult d = DialogBox("WARNING: No pretest data found. Please run the pretest before testing or disable the pretest option. Continuing will disable the option.",
                    "PRETEST Data Not Found", "Continue Anyway", true, "Cancel Test");
                    if (d == DialogResult.Cancel)
                    {
                        skipTest = true;
                    }
                }
                if (!skipTest)
                {
                    settingsSynced = false;
                    stopTest = false;
                    settingsPane1.SaveSettings();
                    inputLagRawData.Clear();
                    inputLagProcessed.Clear();
                    resultsFolderPath = CFuncs.makeResultsFolder(resultsPath, testSettings.GetResultType(testSettings.SensorType), deviceNameBox.Text);
                    // create raw and processed files? or just let the files do that?
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 6)
                    {
                        rawFileName = CFuncs.makeResultsFile(resultsFolderPath, "RAW");
                    }
                    processedFileName = CFuncs.makeResultsFile(resultsFolderPath, "PROCESSED");
                    SetDeviceStatus(5);
                    if (testSettings.TestSource == 1)
                    {
                        runDirectXTest();
                    }
                    else
                    {
                        testThread = new Thread(new ThreadStart(runTest));
                        testThread.Start();
                    }
                }
            }
            else
            {
                //Console.WriteLine("Test thread alive: " +testThread.IsAlive);
                // End test
                portWrite("X");
                stopTest = true;
                MouseMoveTest = false;
                toggleMouseKeyboardBoxes(false);
                SetDeviceStatus(1);

                SaveResultsToFile();
                CFuncs.removeResultsFolder(resultsFolderPath); // if test failed to produce data, remove folder
                if (inputLagProcessed.Count != 0 || inputLagRawData.Count != 0)
                {
                    Thread inputLagThread = new Thread(new ThreadStart(processInputLagData));
                    inputLagThread.Start();
                }
                try { testThread.Abort(); } catch { } // added this as a catch incase the thread is still hanging around

            }
        }

        private void SaveResultsToFile()
        {
            string[] folders = resultsFolderPath.Split('\\');
            string monitorInfo = folders.Last();
            if (inputLagRawData.Count != 0)
            {
                string filePath = resultsFolderPath + "\\" + monitorInfo + "-RAW-OSLTT.csv";
                string strSeparator = ",";
                StringBuilder csvString = new StringBuilder();
                foreach (var res in inputLagRawData)
                {
                    csvString.AppendLine(res.ClickTime.ToString() + "," + res.FrameTime.ToString() + "," + res.TimeTaken.ToString() + "," + res.SampleCount.ToString() + "," + string.Join(strSeparator, res.Samples));
                }
                File.WriteAllText(filePath, csvString.ToString());
            }
            else if (inputLagProcessed.Count != 0)
            {
                //inputLagProcessed
                string filePath = resultsFolderPath + "\\" + monitorInfo + "-RAWRESULTS-OSLTT.csv";
                StringBuilder csvString = new StringBuilder();
                csvString.AppendLine("Result Type,Shot Number,Click Time (ms),Frame Time (ms),On Display Latency (ms),Total Input Latency (ms)");
                foreach (var res in inputLagProcessed)
                {
                    csvString.AppendLine(res.Type.ToString() + "," + res.shotNumber.ToString() + "," + res.frameTimeMs.ToString() + "," + res.clickTimeMs.ToString() + "," + res.onDisplayLatency.ToString() + "," + res.totalInputLag.ToString());
                }
                File.WriteAllText(filePath, csvString.ToString());
            }
        }

        private void SyncSettingsThreadFunc()
        {
            Thread.Sleep(1000);
            if (port != null)
            {
                if (!settingsSynced)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        settingsPane1.SaveSettings();
                    });
                }
            }
        }

        private void runPretest()
        {
            if (systemLagData.inputLagResults == null)
            {
                portWrite("P");
                DirectX.System.DSystem.inputLagMode = true;
                if (DirectX.System.DSystem.mainWindow == null)
                    DirectX.System.DSystem.mainWindow = this;

                DirectX.System.DSystem.StartRenderForm("OSLTT Test Window (DirectX 11)", 800, 600, false, true, settingsPane1.selectedDisplay.DisplayNumber, 1);
            }
        }

        private void runTest()
        {
            try
            {
                while (!settingsSynced) { Thread.Sleep(100); } // can use this because this function is threaded
                portWrite("T");
                RunSettings = SettingsClasses.initRunSettings();
                inputLagEvents.Clear();
                inputLagProcessed.Clear();
                inputLagRawData.Clear();
                ControllerKill = false;
                if (testSettings.TestSource == 2 || testSettings.TestSource == 6 || testSettings.TestSource == 7 || testSettings.TestSource == 8) // mouse/keyboard mode
                {
                    // switch modes then wait for test end
                    toggleMouseKeyboardBoxes(true);
                    if (testSettings.TestSource == 8)
                    {
                        MouseMoveTest = true;
                    }
                }
                else if (testSettings.TestSource == 4) // audio clip
                {
                    // wait for device trigger still right?
                }
                else
                {
                    // erm idk? wait? External/game mode
                }
                while (!stopTest)
                {
                    Thread.Sleep(100);
                }
                SetDeviceStatus(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                debug.AddToLog(ex.Message + ex.StackTrace);
            }
        }

        private void runDirectXTest()
        {
            try
            {
                //while (!settingsSynced) { Thread.Sleep(100); }
                Thread.Sleep(100);

                portWrite("T");
                RunSettings = SettingsClasses.initRunSettings();
                inputLagEvents.Clear();
                inputLagProcessed.Clear();
                inputLagRawData.Clear();

                DirectX.System.DSystem.inputLagMode = true;
                if (DirectX.System.DSystem.mainWindow == null)
                    DirectX.System.DSystem.mainWindow = this;

                DirectX.System.DSystem.StartRenderForm("OSLTT Test Window (DirectX 11)", 800, 600, false, true, settingsPane1.selectedDisplay.DisplayNumber, 1);

                SetDeviceStatus(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                debug.AddToLog(ex.Message + ex.StackTrace);
            }
        }

        private void processPretestData()
        {
            if (rawSystemLagData.Count != 0)
            {
                systemLagData = AverageInputLagResults(rawSystemLagData);
            }
            SetDeviceStatus(1);
            // save pretest data to file?
        }
        private void processInputLagData()
        {
            //inputLagProcessed.Clear();

            try //Wrapped whole thing in try just in case
            {
                // Then process the lines
                averagedInputLag averagedLatency = new averagedInputLag();
                if (inputLagRawData.Count != 0)
                {
                    averagedLatency = AverageInputLagResults(inputLagRawData);
                }
                else if (inputLagProcessed.Count != 0)
                {
                    averagedLatency = AveragePreProecessedResults(inputLagProcessed);
                }

                if (averagedLatency.inputLagResults == null || averagedLatency.inputLagResults.Count == 0)
                {
                    throw new Exception("Failed to Process Results");
                }

                // Write results to csv using new name
                decimal fileNumber = 001;
                // search /Results folder for existing file names, pick new name
                string[] existingFiles = Directory.GetFiles(resultsFolderPath, "*-PROCESSED-OSLTT.csv");
                // Search \Results folder for existing results to not overwrite existing or have save conflict errors
                foreach (var s in existingFiles)
                {
                    decimal num = 0;
                    try
                    { num = decimal.Parse(Path.GetFileNameWithoutExtension(s).Remove(3)); }
                    catch
                    { Console.WriteLine("Non-standard file name found"); }
                    if (num >= fileNumber)
                    {
                        fileNumber = num + 1;
                    }
                }
                string[] folders = resultsFolderPath.Split('\\');
                string monitorInfo = folders.Last();
                string filePath = resultsFolderPath + "\\" + monitorInfo + "-PROCESSED-OSLTT.csv";
                //string filePath = resultsFolderPath + "\\" + fileNumber.ToString("000") + "-INPUT-LAG-OSRTT.csv";

                StringBuilder csvString = new StringBuilder();
                csvString.AppendLine("Shot Number,Click Time (ms),Processing Latency (ms),Display Latency(ms),Total System Input Lag (ms)");

                foreach (var res in averagedLatency.inputLagResults)
                {
                    csvString.AppendLine(
                        res.shotNumber.ToString() + "," +
                        res.clickTimeMs.ToString() + "," +
                        res.frameTimeMs.ToString() + "," +
                        res.onDisplayLatency.ToString() + "," +
                        res.totalInputLag.ToString()
                        );
                }
                csvString.AppendLine("AVERAGE," + averagedLatency.ClickTime.AVG.ToString() + "," + averagedLatency.FrameTime.AVG.ToString() + "," + averagedLatency.onDisplayLatency.AVG.ToString() + "," + averagedLatency.totalInputLag.AVG.ToString());
                csvString.AppendLine("MINIMUM," + averagedLatency.ClickTime.MIN.ToString() + "," + averagedLatency.FrameTime.MIN.ToString() + "," + averagedLatency.onDisplayLatency.MIN.ToString() + "," + averagedLatency.totalInputLag.MIN.ToString());
                csvString.AppendLine("MAXIMUM," + averagedLatency.ClickTime.MAX.ToString() + "," + averagedLatency.FrameTime.MAX.ToString() + "," + averagedLatency.onDisplayLatency.MAX.ToString() + "," + averagedLatency.totalInputLag.MAX.ToString());
                Console.WriteLine(filePath);
                File.WriteAllText(filePath, csvString.ToString());


                this.Invoke((MethodInvoker)delegate ()
                {
                    ResultsView rv = new ResultsView();
                    rv.setResultsFolder(resultsFolderPath);
                    rv.inputLagMode(averagedLatency);
                    rv.Show();
                });
                //Process.Start("explorer.exe", resultsFolderPath);
            }
            catch (Exception procEx)
            {
                Console.WriteLine(procEx);
                processingFailed = true;
                if (port != null)
                {
                    if (port.IsOpen)
                    {
                        port.Write("X");
                        DialogBox("One or more set of results failed to process and won't be included in the multi-run averaging. \n " +
                            "Brightness may be too high or monitor may be strobing it's backlight. \n" +
                            "Try calibrating the brightness again, or use the Graph View Template to view the raw data.", "Processing Failed", "OK", false);
                        processingFailed = false;
                    }
                }
            }
        }

        private void textTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //sw.Stop();
            //double ticks = sw.ElapsedTicks;
            //double seconds = ticks / Stopwatch.Frequency;
            //double microseconds = (ticks / Stopwatch.Frequency) * 1000000;
            //Console.WriteLine("Click handler: " + microseconds);
            // text changed handler added 487us.
            //3-4ms direct (osltt test mode)
            portWrite("H");
            Console.WriteLine("H sent");  // this is firing twice??
        }

        private void materialLabel11_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //clickTestBox_Click(null, null);
            portWrite("H");
            Console.WriteLine("H sent");
        }

        private void clickTestBox_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // click handlers added 87us
            // 1.1ms avg added waiting for click handler (triggered with mouse clicks)
            portWrite("H");
            Console.WriteLine("H sent");
        }
        bool testbool = false;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            //UpdateFirmware.getNewFirmwareFile();

            //DirectX.System.DSystem.inputLagMode = true;
            //if (DirectX.System.DSystem.mainWindow == null)
            //DirectX.System.DSystem.mainWindow = this;

            //DirectX.System.DSystem.StartRenderForm("OSLTT Test Window (DirectX 11)", 800, 600, false, true, 0, 1);

            //audioTestClip.Play();

            //sw.Restart();

            //portWrite("W");
            //textTextBox.Text = "test";
            /*testbool = !testbool;
            toggleMouseKeyboardBoxes(testbool);
            if (testbool)
            {
                portWrite("Y");
                mouseHook.Install();
            }
            else
            {
                portWrite("X");
                mouseHook.Uninstall();
            }*/

            //portWrite("Z");
            //boardUpdate = true;
            //mouseHook.Install();

            //runPretestButton.Enabled = !runPretestButton.Enabled;

            //Console.WriteLine(testThread.IsAlive);
            //Thread t = new Thread(new ThreadStart(ControllerEventHandler));
            //t.Start();
            Stopwatch sw = new Stopwatch();
            var xaudio2 = new XAudio2();
            var masteringVoice = new MasteringVoice(xaudio2);
            sw.Start();
            PlaySoundFile(xaudio2);
            sw.Stop();
            masteringVoice.Dispose();
            xaudio2.Dispose();
            
            //audioTestClip.Play(); 
            Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds + "ms");
        }

        private void monitorPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.MonitorPreset();
        }

        private void miceKeyboardPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.MouseKeyboardPreset();
        }
        private void gamepadPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.GamepadPreset();
        }

        private void keyboardPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.KeyboardPreset();
        }

        private void gamePresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.GamesPreset();
        }

        private void headsetPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.AudioPreset();
        }

        private void consolesPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.ConsolePreset();
        }

        private void customPresetBtn_Click(object sender, EventArgs e)
        {
            settingsPane1.CustomPreset1();
        }

        private void resultsViewBtn_Click(object sender, EventArgs e)
        {
            ResultsView res = new ResultsView();
            res.importMode();
            res.Show();
        }

        private void hotkeySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                try
                {
                    string selected = s.Items[s.SelectedIndex].ToString();
                    Key newKey = hotkeysDict[selected];
                    if (hotKeyList.Count > 0)
                    {
                        hotKeys.Unregister(hotKeyList[0].Key, System.Windows.Input.ModifierKeys.None);
                        hotKeyList.Clear();
                    }
                    var k = hotKeys.Register(newKey, System.Windows.Input.ModifierKeys.None);
                    hotKeyList.Add(k);
                    Properties.Settings.Default.hotkey = selected;
                    Properties.Settings.Default.Save();
                }
                catch { }
            }   
        }
        public Dictionary<string, Key> hotkeysDict = new Dictionary<string, Key> {
                { "F1", Key.F1 },
                { "F2", Key.F2 },
                { "F3", Key.F3 },
                { "F4", Key.F4 },
                { "F5", Key.F5 },
                { "F6", Key.F6 },
                { "F7", Key.F7 },
                { "F8", Key.F8 },
                { "F9", Key.F9 },
                { "F10", Key.F10 },
                { "F11", Key.F11 },
                { "F12", Key.F12 },
            };
        private void fillHotkeyList()
        {
            var preset = Properties.Settings.Default.hotkey;
            int count = 0; // I know I could do this with a for loop but it's midnight I cba
            int sel = 0;
            foreach (var i in hotkeysDict)
            {
                hotkeySelect.Items.Add(i.Key);
                if (i.Key != preset) { count++; }
                else { sel = count; }
            }
            hotkeySelect.SelectedIndex = sel;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            portWrite("Z1");
        }

        private void resultsFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start(resultsPath);
        }

        
    }

}
