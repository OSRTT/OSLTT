using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OSLTT
{
    class UpdateFirmware
    {
        private static string releasesUrl = "https://api.github.com/repos/andymanic/OSRTT/releases/latest";
        private static string newFirmwareUrl = "";


        public static double getNewFirmwareFile()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("user-agent", "OSLTT");
                
                try
                {
                    string latest = wc.DownloadString(releasesUrl);
                    //object jsonData = JsonConvert.DeserializeObject(latest);
                    //Console.WriteLine(jsonData);
                    string[] splitMessage = latest.Split('}');
                    foreach (var s in splitMessage)
                    {
                        if (s.Contains("browser_download_url"))
                        {
                            string[] splitForUrl = s.Split('"');
                            foreach (var st in splitForUrl)
                            {
                                if (st.StartsWith("https://github.com/") && st.Contains(".zip")) // change to .ino.bin for prod
                                {
                                    newFirmwareUrl = st;
                                    break;
                                }
                            }
                            if (newFirmwareUrl != "")
                            {
                                break;
                            }
                        }
                    }
                    //wc.DownloadFile(newFirmwareUrl, @"C:\OSLTT\arduinoCLI\");
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
    }
}
