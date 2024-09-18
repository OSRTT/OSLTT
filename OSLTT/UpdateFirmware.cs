using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OSLTT
{
    class UpdateFirmware
    {
        private static string releasesUrl = "https://api.github.com/repos/OSRTT/OSLTT/releases/latest";
        private static string newFirmwareUrl = "";

        public static void initialSetup()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var samdCore = appData + "\\Arduino15\\packages\\Seeeduino\\hardware\\samd";
            var adafruitCore = appData + "\\Arduino15\\packages\\adafruit\\hardware\\samd";
            Console.WriteLine(samdCore);
            if (!Directory.Exists(samdCore))
            {
                DialogResult d = MessageBox.Show("Further setup is required to connect and update device, do that now?", "Setup Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe config init";
                    //process.StartInfo.UseShellExecute = false;
                    //process.StartInfo.RedirectStandardOutput = true;
                    //process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    //string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    //Console.WriteLine(output);
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe config set directories.user \"C:\\OSRTT Launcher\\arduinoCLI\"";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe config add board_manager.additional_urls https://files.seeedstudio.com/arduino/package_seeeduino_boards_index.json";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe core update-index && .\\arduinoCLI\\arduino-cli.exe core install arduino:samd && .\\arduinoCLI\\arduino-cli.exe core install Seeeduino:samd";
                    process.Start();
                    process.WaitForExit();
                }
            }
            if (!Directory.Exists(adafruitCore))
            {
                DialogResult d = MessageBox.Show("Further setup is required to connect and update device, do that now?", "Setup Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe config init";
                    //process.StartInfo.UseShellExecute = false;
                    //process.StartInfo.RedirectStandardOutput = true;
                    //process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    //string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    //Console.WriteLine(output);
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe config set directories.user \"C:\\OSRTT Launcher\\arduinoCLI\"";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe config add board_manager.additional_urls https://adafruit.github.io/arduino-board-index/package_adafruit_index.json";
                    process.Start();
                    process.WaitForExit();
                    process.StartInfo.Arguments = "/C .\\arduinoCLI\\arduino-cli.exe core update-index && .\\arduinoCLI\\arduino-cli.exe core install arduino:samd && .\\arduinoCLI\\arduino-cli.exe core install adafruit:samd";
                    process.Start();
                    process.WaitForExit();
                }
            }
        }

        public static double getNewFirmwareFile(string localPath)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("user-agent", "OSLTT");

                try
                {
                    string latest = wc.DownloadString(releasesUrl);
                    string[] splitMessage = latest.Split('}');
                    foreach (var s in splitMessage)
                    {
                        if (s.Contains("browser_download_url"))
                        {
                            string[] splitForUrl = s.Split('"');
                            foreach (var st in splitForUrl)
                            {
                                if (st.StartsWith("https://github.com/") && st.Contains(".ino.bin")) // change to .ino.bin for prod
                                {
                                    newFirmwareUrl = st;
                                    string[] filename = newFirmwareUrl.Split('/');
                                    wc.DownloadFile(newFirmwareUrl, localPath + @"\\arduinoCLI\\" + filename.Last());
                                }
                            }
                            if (newFirmwareUrl != "")
                            {
                                //break;
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ex.StackTrace);
                }

            }
            if (newFirmwareUrl != "")
            {
                string[] fileSplit = newFirmwareUrl.Split('/');
                string[] fileVersion = fileSplit.Last().Split('_');
                string fileNumber = fileVersion.Last();
                fileNumber = fileNumber.Remove(fileNumber.Length - 8);
                return double.Parse(fileNumber);
            }
            return 0;
        }

        public class FirmwareReport
        {
            public string ErrorMessage { get; set; }
            public int State { get; set; }
            public string ConsoleOutput { get; set; }
        }

        public static FirmwareReport UpdateDeviceFirmware(string localPath, string p, int boardType = 0)
        {
            FirmwareReport fwr = new FirmwareReport { ErrorMessage = "", State = 0, ConsoleOutput="" };
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            string updateCommand = "";

            string binFileAvailable = "";
            string csBinFile = "";
            foreach (var f in Directory.GetFiles(localPath + @"\\arduinoCLI"))
            {
                if (f.Contains("ino.bin") && !f.Contains("CS") && boardType == 0) { binFileAvailable = f; }
                if (f.Contains("ino.bin") && f.Contains("CS") && boardType == 1) { csBinFile = f; }
            }
            if (binFileAvailable != "" && boardType == 0)
            {
                Console.WriteLine(binFileAvailable);
                updateCommand = "/C .\\arduinoCLI\\arduino-cli.exe upload --port " + p + " --fqbn Seeeduino:samd:seeed_XIAO_m0 -i \"" + binFileAvailable + "\"";
                Console.WriteLine(updateCommand);
            }
            else if (csBinFile != "" && boardType == 1)
            {
                Console.WriteLine(binFileAvailable);
                updateCommand = "/C .\\arduinoCLI\\arduino-cli.exe upload --port " + p + " --fqbn adafruit:samd:adafruit_feather_m0 -i \"" + csBinFile + "\"";
                Console.WriteLine(updateCommand);
            }
            else
            {
                return new FirmwareReport { State = 4, ConsoleOutput = "", ErrorMessage = "No Binary File Available" };
            }

            Console.WriteLine("ready to start");
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = updateCommand;
            try
            {
                Console.WriteLine("starting update");
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
                fwr.ConsoleOutput = output;
                process.WaitForExit();
                //MessageBox.Show(output);
                if (output.Contains("error"))
                {
                    //MessageBox.Show("Firmware update failed. Error message: " + output, "Update Device Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fwr.ErrorMessage = "Failed to update device firmware, check debug log for more information";
                    fwr.State = 4;
                }
                else
                {
                    //MessageBox.Show("Device has been updated successfully!", "Updated Device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fwr.ErrorMessage = "Device updated successfully";
                    fwr.State = 3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write to device, check it's connected via USB.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
                fwr.ErrorMessage = ex.Message + ex.StackTrace;
            }
            return fwr;
        }
    }
}
