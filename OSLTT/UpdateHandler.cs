using AutoUpdaterDotNET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    public class UpdateHandler
    {
        public static void UpdateMe(string softwareVersion)
        {
            AutoUpdater.InstalledVersion = new Version(softwareVersion);
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Days;
            AutoUpdater.RemindLaterAt = 2;
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.HttpUserAgent = "Autoupdater";
            AutoUpdater.UpdateFormSize = new System.Drawing.Size(1200, 800);
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdaterOnParseUpdateInfoEvent;
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            AutoUpdater.Start("https://api.github.com/repos/OSRTT/OSLTT/releases/latest");
        }

        private static void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            string dlUrl = "";
            foreach (var a in json.assets)
            {
                string tmp = a.browser_download_url;
                if (tmp.Contains(".zip"))
                {
                    dlUrl = tmp;
                }
            }
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.tag_name,
                ChangelogURL = json.html_url,
                DownloadURL = dlUrl,
            };
        }
        private static void AutoUpdater_ApplicationExitEvent()
        {
            Properties.Settings.Default.updateInProgress = true;
            Properties.Settings.Default.Save();

            Application.Exit();
        }

        public class AnnouncementText
        {
            public string titleText { get; set; } = "No updates found";
            public string descriptionText { get; set; } = "";
            public bool Read { get; set; }
        }

        public static AnnouncementText GetAnnouncements(string localPath)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("user-agent", "OSLTT");

                try
                {
                    List<AnnouncementText> existingList;
                    if (File.Exists(localPath + @"\\announcements.json"))
                    {
                        existingList = JsonConvert.DeserializeObject<List<AnnouncementText>>(File.ReadAllText(localPath + @"\\announcements.json"));
                    }
                    else
                    {
                        existingList = new List<AnnouncementText>();
                    }

                    string url = "https://raw.githubusercontent.com/OSRTT/OSLTT/main/OSLTT/announcements.json";
                    //wc.DownloadFile(url, localPath + @"announcements.json");
                    string content = wc.DownloadString(url);
                    List<AnnouncementText> jsonified = JsonConvert.DeserializeObject<List<AnnouncementText>>(content);

                    if (jsonified.Count() > existingList.Count())
                    {
                        // there's new shit probably.
                        // save new list to file
                        jsonified.Last().Read = true;
                        File.Delete(localPath + @"\\announcements.json");
                        File.WriteAllText(localPath + @"\\announcements.json", JsonConvert.SerializeObject(jsonified));
                        // return newest results
                        return jsonified.Last();
                    }
                    else if (!existingList.Last().Read)
                    {
                        // last result hasn't been shown yet. (somehow)
                        existingList.Last().Read = true;
                        File.Delete(localPath + @"\\announcements.json");
                        File.WriteAllText(localPath + @"\\announcements.json", JsonConvert.SerializeObject(existingList));
                        return existingList.Last();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ex.StackTrace);
                }

            }

            return null;
        }

    }
}
