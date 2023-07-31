using AutoUpdaterDotNET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    class UpdateHandler
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
    }
}
