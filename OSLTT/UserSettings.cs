using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLTT
{
    class UserSettings
    {
        class userSettings
        {
            public class usersetting
            {
                public string name { get; set; }
                public string value { get; set; }
            }
            public List<usersetting> usersettings { get; set; } = new List<usersetting>();
        }
        public static void readAndSaveUserSettings(bool closing)
        {
            string UserSettingsFile = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            UserSettingsFile = new Uri(System.IO.Path.GetDirectoryName(UserSettingsFile)).LocalPath;
            UserSettingsFile += @"\\userSettings.json";
            try
            {
                if (closing)
                {
                    // write settings to file
                    userSettings us = new userSettings();
                    foreach (System.Configuration.SettingsProperty s in Properties.Settings.Default.Properties)
                    {
                        if (s.Name == "customTestSettings")
                        {
                            string ts = JsonConvert.SerializeObject(Properties.Settings.Default.customTestSettings);
                            us.usersettings.Add(new userSettings.usersetting { name = "customTestSettings", value = ts });
                        }
                        else
                        {
                            us.usersettings.Add(new userSettings.usersetting { name = s.Name, value = Properties.Settings.Default[s.Name].ToString() });
                        }
                    }
                    string jsonData = JsonConvert.SerializeObject(us);
                    File.WriteAllText(UserSettingsFile, jsonData);
                }
                else if (File.Exists(UserSettingsFile))
                {
                    // opening program, read settings from file
                    string contents = File.ReadAllText(UserSettingsFile);
                    userSettings settings = JsonConvert.DeserializeObject<userSettings>(contents);
                    foreach (userSettings.usersetting s in settings.usersettings)
                    {
                        if (s.name == "customTestSettings")
                        {
                            try
                            {
                                Properties.Settings.Default.customTestSettings = JsonConvert.DeserializeObject<TestSettings>(s.value);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message + e.StackTrace);
                            }
                        }
                        else
                        {
                            try
                            {
                                Type t = Properties.Settings.Default[s.name].GetType();
                                Properties.Settings.Default[s.name] = Convert.ChangeType(s.value, t);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message + e.StackTrace);
                            }
                        }
                    }
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }

    }
}
