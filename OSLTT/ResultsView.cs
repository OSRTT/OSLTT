using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace OSLTT
{
    public partial class ResultsView : MaterialForm
    {
        public string resultsFolderPath = "";
        public string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
        public ProcessData.averagedInputLag inputLagResults { get; set; }
        public int type = 2;
        private bool ScatterOption = false;

        public ResultsView()
        {
            InitializeComponent();
            path = new Uri(System.IO.Path.GetDirectoryName(path)).LocalPath;
            path += @"\Results";
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void setResultsFolder(string p)
        {
            resultsFolderPath = p;
        }

        public void inputLagMode(ProcessData.averagedInputLag il)
        {
            graphMode();
        }

        public void importMode()
        {
            Size = new Size(720, 156);
            importPanel.Visible = true;
            importPanel.BringToFront();
            barPlot.Visible = false;
            barPlot.SendToBack();
            controlsPanel.Visible = false;
            controlsPanel.SendToBack();
        }

        public void graphMode()
        {
            Size = new Size(1222, 829);
            importPanel.Visible = false;
            importPanel.SendToBack();
            barPlot.Visible = true;
            barPlot.BringToFront();
            controlsPanel.Visible = true;
            controlsPanel.BringToFront();
        }

        public void drawScatterGraph()
        {
            this.Text = "On Display Latency";
            graphedData.Plot.Clear();
            double[] xs = new double[inputLagResults.inputLagResults.Count];
            double[] ys = new double[inputLagResults.inputLagResults.Count];
            for (int i = 0; i < inputLagResults.inputLagResults.Count; i++)
            {
                xs[i] = inputLagResults.inputLagResults[i].shotNumber;
                if (type == 0)
                {
                    ys[i] = inputLagResults.inputLagResults[i].clickTimeMs;
                }
                else if (type == 1)
                {
                    ys[i] = inputLagResults.inputLagResults[i].frameTimeMs;
                }
                else if (type == 2)
                {
                    ys[i] = inputLagResults.inputLagResults[i].onDisplayLatency;
                }
                else if (type == 3)
                {
                    ys[i] = inputLagResults.inputLagResults[i].totalInputLag;
                }
            }
            graphedData.Plot.AddScatter(xs, ys, null, 3, 10);
            //graphedData.Plot.Title("");
            graphedData.Plot.Legend(false);
            graphedData.Plot.Style(null, SystemColors.ControlDark, Color.LightGray);

            graphedData.Plot.XAxis.TickLabelStyle(Color.Black, "Calibri", 20, false);
            graphedData.Plot.YAxis.TickLabelStyle(Color.Black, "Calibri", 20, false);
            //graphedData.Plot.SetAxisLimitsY(0, inputLagResults.totalInputLag.MAX + 1);

            graphedData.Plot.AddHorizontalLine(inputLagResults.onDisplayLatency.AVG, Color.DarkGreen, 5);

            graphedData.Plot.Render();
            graphedData.Plot.RenderLegend();
            graphedData.Render();
            graphedData.Refresh();
        }
        public void drawBarGraph()
        {
            this.Text = "Latency Results";
            barPlot.Plot.Clear();
            double[][] values = new double[3][];
            values[0] = new double[4];
            values[1] = new double[4];
            values[2] = new double[4];
            string[] titles = { "USB Polling Delay", "Render Time", "On Display Lag", "Total Input Lag" };
            string[] labels = { "AVG", "MIN", "MAX" };
            values[0][0] = inputLagResults.ClickTime.AVG;
            values[1][0] = inputLagResults.ClickTime.MIN;
            values[2][0] = inputLagResults.ClickTime.MAX;
            values[0][1] = inputLagResults.FrameTime.AVG;
            values[1][1] = inputLagResults.FrameTime.MIN;
            values[2][1] = inputLagResults.FrameTime.MAX;
            values[0][2] = inputLagResults.onDisplayLatency.AVG;
            values[1][2] = inputLagResults.onDisplayLatency.MIN;
            values[2][2] = inputLagResults.onDisplayLatency.MAX;
            values[0][3] = inputLagResults.totalInputLag.AVG;
            values[1][3] = inputLagResults.totalInputLag.MIN;
            values[2][3] = inputLagResults.totalInputLag.MAX;

            barPlot.Plot.Style(null, SystemColors.ControlDark);
            barPlot.Plot.AddBarGroups(titles, labels, values, null);
            barPlot.Plot.Legend(location: ScottPlot.Alignment.UpperLeft);
            barPlot.Plot.XAxis.Grid(false);
            barPlot.Plot.XAxis.TickLabelStyle(Color.Black, "Calibri", 24, true);
            barPlot.Plot.YAxis.TickLabelStyle(Color.Black, "Calibri", 20, false);
            barPlot.Plot.SetAxisLimitsY(0, inputLagResults.totalInputLag.MAX + 1);
            barPlot.Plot.Render();
            barPlot.Refresh();

            string[] existingFiles = Directory.GetFiles(resultsFolderPath, "*.png");
            /*if (existingFiles.Length == 0 && Properties.Settings.Default.autoSavePNG != 0)
            {
                if (Properties.Settings.Default.autoSavePNG == 1)
                {
                    savePNGBtn_Click(null, null);
                }
                else
                {
                    saveWhitePNGBtn_Click(null, null);
                }
            }*/
        }

        private void switchGraphTypeBtn_Click(object sender, EventArgs e)
        {
            ScatterOption = !ScatterOption;

            if (ScatterOption)
            {
                switchGraphTypeBtn.Text = "Switch to Averaged Results";
                barPlot.Visible = false;
                barPlot.Enabled = false;
                barPlot.SendToBack();
                graphedData.Visible = true;
                graphedData.Enabled = true;
                graphedData.BringToFront();
                drawScatterGraph();
            }
            else
            {
                switchGraphTypeBtn.Text = "Switch to Individual Results";
                graphedData.Visible = false;
                graphedData.Enabled = false;
                graphedData.SendToBack();
                barPlot.Visible = true;
                barPlot.Enabled = true;
                barPlot.BringToFront();
                drawBarGraph();
            }
        }

        private void savePNGBtn_Click(object sender, EventArgs e)
        {
            if (ScatterOption)
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-SCATTER");
                Color bnColor = BackColor;
                graphedData.Plot.Style(figureBackground: Color.Transparent, dataBackground: Color.Transparent);
                graphedData.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                graphedData.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            }
            else
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-CHART");
                Color bnColor = BackColor;
                barPlot.Plot.Style(figureBackground: Color.Transparent, dataBackground: Color.Transparent);
                barPlot.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                barPlot.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            }
        }

        private void saveWhitePNGBtn_Click(object sender, EventArgs e)
        {
            if (ScatterOption)
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-SCATTER");
                Color bnColor = BackColor;
                graphedData.Plot.Style(figureBackground: Color.White, dataBackground: Color.White);
                graphedData.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                graphedData.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            }
            else
            {
                string run = CFuncs.createIMGFileName(resultsFolderPath, "LATENCY-CHART");
                Color bnColor = BackColor;
                barPlot.Plot.Style(figureBackground: Color.White, dataBackground: Color.White);
                barPlot.Plot.SaveFig(resultsFolderPath + "\\" + run, 1920, 1080, false);
                barPlot.Plot.Style(figureBackground: bnColor, dataBackground: bnColor);
                Process.Start("explorer.exe", resultsFolderPath);
            }
        }

        private void importRawBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var rawData = importRawInputLagData(path); 
                if (rawData.Count != 0)
                {
                    var data = ProcessData.AverageInputLagResults(rawData);
                    // Write results to csv using new name
                    decimal fileNumber = 001;
                    // search /Results folder for existing file names, pick new name
                    string[] existingFiles = Directory.GetFiles(resultsFolderPath, "*-INPUT-LATENCY-OSRTT.csv");
                    // Search \Results folder for existing results to not overwrite existing or have save conflict errors
                    foreach (var s in existingFiles)
                    {
                        decimal num = 0;
                        Console.WriteLine(Path.GetFileNameWithoutExtension(s).Remove(3));
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
                    string filePath = resultsFolderPath + "\\" + monitorInfo + "-INPUT-LATENCY-OSRTT.csv";
                    //string filePath = resultsFolderPath + "\\" + fileNumber.ToString("000") + "-INPUT-LAG-OSRTT.csv";

                    string strSeparator = ",";
                    StringBuilder csvString = new StringBuilder();
                    csvString.AppendLine("Shot Number,Click Time (ms),Processing Latency (ms),Display Latency(ms),Total System Input Lag (ms)");

                    foreach (var res in data.inputLagResults)
                    {
                        csvString.AppendLine(
                            res.shotNumber.ToString() + "," +
                            res.clickTimeMs.ToString() + "," +
                            res.frameTimeMs.ToString() + "," +
                            res.onDisplayLatency.ToString() + "," +
                            res.totalInputLag.ToString()
                            );
                    }
                    csvString.AppendLine("AVERAGE," + data.ClickTime.AVG.ToString() + "," + data.FrameTime.AVG.ToString() + "," + data.onDisplayLatency.AVG.ToString() + "," + data.totalInputLag.AVG.ToString());
                    csvString.AppendLine("MINIMUM," + data.ClickTime.MIN.ToString() + "," + data.FrameTime.MIN.ToString() + "," + data.onDisplayLatency.MIN.ToString() + "," + data.totalInputLag.MIN.ToString());
                    csvString.AppendLine("MAXIMUM," + data.ClickTime.MAX.ToString() + "," + data.FrameTime.MAX.ToString() + "," + data.onDisplayLatency.MAX.ToString() + "," + data.totalInputLag.MAX.ToString());
                    Console.WriteLine(filePath);
                    File.WriteAllText(filePath, csvString.ToString());
                    inputLagMode(data);
                }
                else
                {
                    MessageBox.Show("Failed to import data", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            var data = importInputLagData(path); 
            if (data.inputLagResults.Count != 0)
            {
                inputLagMode(data);
            }
            else
            {
                MessageBox.Show("Failed to import data", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ProcessData.averagedInputLag importInputLagData(string path)
        {
            // Open file picker dialogue
            var filePath = string.Empty;
            ProcessData.averagedInputLag averagedInputLag = new ProcessData.averagedInputLag();
            averagedInputLag.inputLagResults = new List<ProcessData.inputLagResult>();
            averagedInputLag.ClickTime = new ProcessData.averageInputLagResult();
            averagedInputLag.FrameTime = new ProcessData.averageInputLagResult();
            averagedInputLag.onDisplayLatency = new ProcessData.averageInputLagResult();
            averagedInputLag.totalInputLag = new ProcessData.averageInputLagResult();
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    if (filePath.Contains("LATENCY-OSRTT"))
                    {
                        //Read the contents of the file into a stream
                        try
                        {
                            var fileStream = openFileDialog.OpenFile();
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                while (!reader.EndOfStream)
                                {
                                    // This can probably be done better
                                    string fullLine = reader.ReadLine();
                                    if (fullLine.Contains("{"))
                                    {
                                        SettingsClasses.RunSettings runs = JsonConvert.DeserializeObject<SettingsClasses.RunSettings>(fullLine);
                                        //runSettings = runs;
                                        continue;
                                    }
                                    else if (fullLine.Contains("Shot"))
                                    {
                                        //skip headers
                                    }
                                    else
                                    {
                                        string[] line = fullLine.Split(',');
                                        double[] intLine = new double[line.Length];
                                        string azpattern = "[a-z]+";
                                        if (line[0].Contains("A") || line[0].Contains("M"))
                                        {
                                            for (int i = 1; i < line.Length; i++)
                                            {
                                                if (line[i] == "0")
                                                {
                                                    intLine[i] = 0;
                                                }
                                                else if (line[i] != "")
                                                {
                                                    intLine[i] = double.Parse(line[i]);
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                            if (line[0].Contains("AV"))
                                            {
                                                averagedInputLag.ClickTime.AVG = intLine[1];
                                                averagedInputLag.FrameTime.AVG = intLine[2];
                                                averagedInputLag.onDisplayLatency.AVG = intLine[3];
                                                averagedInputLag.totalInputLag.AVG = intLine[4];
                                            }
                                            else if (line[0].Contains("MIN"))
                                            {
                                                averagedInputLag.ClickTime.MIN = intLine[1];
                                                averagedInputLag.FrameTime.MIN = intLine[2];
                                                averagedInputLag.onDisplayLatency.MIN = intLine[3];
                                                averagedInputLag.totalInputLag.MIN = intLine[4];
                                            }
                                            else if (line[0].Contains("MAX"))
                                            {
                                                averagedInputLag.ClickTime.MAX = intLine[1];
                                                averagedInputLag.FrameTime.MAX = intLine[2];
                                                averagedInputLag.onDisplayLatency.MAX = intLine[3];
                                                averagedInputLag.totalInputLag.MAX = intLine[4];
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < line.Length; i++)
                                            {
                                                if (line[i] == "0")
                                                {
                                                    intLine[i] = 0;
                                                }
                                                else if (line[i] != "")
                                                {
                                                    intLine[i] = double.Parse(line[i]);
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                            //Array.Resize(ref intLine, intLine.Length - 1);
                                            ProcessData.inputLagResult rawResult = new ProcessData.inputLagResult
                                            {
                                                shotNumber = Convert.ToInt32(intLine[0]),
                                                clickTimeMs = intLine[1],
                                                frameTimeMs = intLine[2],
                                                onDisplayLatency = intLine[3],
                                                totalInputLag = intLine[4]
                                            };
                                            averagedInputLag.inputLagResults.Add(rawResult);
                                        }
                                    }
                                }
                            }
                            resultsFolderPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
                        }
                        catch (Exception ex)
                        {
                            DialogResult d = MessageBox.Show("File may be in use by another program, please make sure it's not open elsewhere and try again.", "Unable to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex.Message + ex.StackTrace);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, only 'RAW' files can be imported. Please select a 'LATENCY-OSRTT.csv' file instead.", "Importer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("Importer Error");
                    }
                }
            }
            return averagedInputLag;
        }

        private List<ProcessData.rawInputLagResult> importRawInputLagData(string path)
        {
            // Open file picker dialogue
            var filePath = string.Empty;
            List<ProcessData.rawInputLagResult> rawILData = new List<ProcessData.rawInputLagResult>();
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    if (filePath.Contains("LATENCY-RAW"))
                    {
                        //Read the contents of the file into a stream
                        try
                        {
                            var fileStream = openFileDialog.OpenFile();
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                while (!reader.EndOfStream)
                                {
                                    // This can probably be done better
                                    string fullLine = reader.ReadLine();
                                    if (fullLine.Contains("{"))
                                    {
                                        SettingsClasses.RunSettings runs = JsonConvert.DeserializeObject<SettingsClasses.RunSettings>(fullLine);
                                        //runSettings = runs;
                                        continue;
                                    }
                                    else
                                    {
                                        string[] line = fullLine.Split(',');
                                        int[] intLine = new int[line.Length];
                                        float frameTime = 0;
                                        for (int i = 0; i < line.Length; i++)
                                        {
                                            if (line[i] == "0")
                                            {
                                                intLine[i] = 0;
                                            }
                                            else if (line[i].Contains("."))
                                            {
                                                frameTime = float.Parse(line[i]);
                                            }
                                            else if (line[i] != "")
                                            {
                                                intLine[i] = int.Parse(line[i]);
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                        Array.Resize(ref intLine, intLine.Length - 1);
                                        List<int> samples = intLine.ToList();
                                        samples.RemoveRange(0, 4);
                                        ProcessData.rawInputLagResult rawResult = new ProcessData.rawInputLagResult
                                        {
                                            ClickTime = intLine[0],
                                            FrameTime = frameTime,
                                            TimeTaken = intLine[2],
                                            SampleCount = intLine[3],
                                            Samples = samples
                                        };
                                        rawILData.Add(rawResult);
                                    }
                                }
                            }
                            resultsFolderPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
                        }
                        catch (Exception ex)
                        {
                            DialogResult d = MessageBox.Show("File may be in use by another program, please make sure it's not open elsewhere and try again.", "Unable to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine(ex.Message + ex.StackTrace);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, only 'RAW' files can be imported. Please select a 'LATENCY-OSRTT.csv' file instead.", "Importer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //throw new Exception("Importer Error");
                    }
                }
            }
            return rawILData;
        }

    }
}
