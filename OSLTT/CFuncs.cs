using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    class CFuncs
    {
        public static DialogResult showMessageBox(string title, string message, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (true)
            {
                DialogResult d = MessageBox.Show(title, message, buttons, icon);
                return d;
            }
            else
            {
                return DialogResult.None;
            }
        }

        public static void HyperlinkOut(string url)
        {
            Process.Start(url);
        }


        public static void appRunning()
        {
            Process[] p = Process.GetProcessesByName("OSRTT Launcher");
            if (p.Length > 1)
            {
                showMessageBox("ERROR: Program already open! Please close it before running again, or check the task bar and system tray for the running app.", "Program Open Already", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(p.Length);
                //this.Close();
            }
        }

        public static void IFailedYou(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            string type = e.Message.ToString();

            if (type != "Safe handle has been closed")
            {
                MessageBox.Show(e.Message, "Unexpected Error - Program Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type.Contains("TimeoutException") || type.Contains("operation has timed out"))
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
            else
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
        }

        public static void checkFolderPermissions(string path)
        {
            string filePath = path + "\\permissionsTest";
            bool test = false;
            try
            {
                Directory.CreateDirectory(filePath);
                test = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Access to the path"))
                {
                    MessageBox.Show("Permissions Error - program unable to create new results folders. \n The program may be installed in the wrong location." +
                        "Please check, or relaunch the program as admin.", "Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            finally
            {
                if (test)
                {
                    Directory.Delete(filePath);
                }
            }
        }

        public static string makeResultsFolder(string path, ProcessData.resultType type, string deviceName="OSLTT")
        {
            if (deviceName=="")
            {
                deviceName = "OSLTT";
            }
            decimal fileNumber = 001;
            // search /Results folder for existing file names, pick new name
            string[] existingFiles = Directory.GetDirectories(path, deviceName + "-*");
            //search files for number
            if (existingFiles.Length != 0)
            {
                foreach (var s in existingFiles)
                {
                    var name = new DirectoryInfo(s).Name;
                    string[] splitMe = name.Split('-');
                    decimal num = decimal.Parse(splitMe.Last());
                    if (num >= fileNumber)
                    {
                        fileNumber = num + 1;
                    }
                }
            }
            string typeName = "LIGHT";
            if (type == ProcessData.resultType.Audio)
            { typeName = "AUDIO"; }
            else if (type == ProcessData.resultType.Click)
            { typeName = "CLICK"; }
            string filePath = path + "\\" + deviceName + "-" + typeName + "-" + fileNumber.ToString("000");
            Directory.CreateDirectory(filePath);
            return filePath;
            //initRunSettingsFile(filePath, monitor);
        }

        public static void removeResultsFolder(string path)
        {
            // search /Results folder for existing file names, pick new name
            string[] existingFiles = Directory.GetFiles(path);
            //search files for number
            if (existingFiles.Length == 0)
            {
                Directory.Delete(path);
            }
        }

        public static string makeResultsFile(string path, string type = "RAW")
        {
            if (type == "")
            {
                type = "RAW";
            }
            string[] folders = path.Split('\\');
            string[] parts = folders.Last().Split('-');
            string filePath = "";
            Regex regexMatchString = new Regex(@"\d\d\d");
            foreach (var s in parts)
            {
                if (regexMatchString.IsMatch(s))
                {
                    filePath += type + "-" + s;
                }
                else
                {
                    filePath += s + "-";
                }
            }
            filePath += ".csv";
            return filePath;
            //initRunSettingsFile(filePath, monitor);
        }

        public static void saveRawResultToFile(string path, string fileName, ProcessData.rawInputLagResult res)
        {
            string strSeparator = ",";
            StringBuilder csvString = new StringBuilder();
            csvString.AppendLine(res.ClickTime.ToString() + "," + res.FrameTime.ToString() + "," + res.TimeTaken.ToString() + "," + res.SampleCount.ToString() + "," + string.Join(strSeparator, res.Samples));
            
            File.AppendAllText(path + "\\" + fileName, csvString.ToString());
        }

        public static string createIMGFileName(string path, string type)
        {
            string[] folders = path.Split('\\');
            decimal fileNumber = 001;
            // search /Results folder for existing file names, pick new name
            string[] existingFiles = Directory.GetFiles(path, "*.png");
            //search files for number
            if (existingFiles.Length != 0)
            {
                foreach (var s in existingFiles)
                {
                    var name = new DirectoryInfo(s).Name;
                    string[] splitMe = name.Split('-');
                    decimal num = decimal.Parse(splitMe.Last());
                    if (num >= fileNumber)
                    {
                        fileNumber = num + 1;
                    }
                }
            }
            string filePath = fileNumber.ToString("000") + "-";

            string[] parts = folders.Last().Split('-');
            Regex regexMatchString = new Regex(@"\d\d\d");
            foreach (var s in parts)
            {
                if (regexMatchString.IsMatch(s))
                {
                    filePath += type;
                }
                else
                {
                    filePath += s + "-";
                }
            }
            filePath += ".png";
            return filePath;
        }

        

    }
}
