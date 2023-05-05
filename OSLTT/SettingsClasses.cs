using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLTT
{
    public class SettingsClasses
    {
        public class RunSettings
        {
            public int TriggerType { get; set; }
            public int SensorType { get; set; }
            public int SourceType { get; set; }
            public bool PreTest { get; set; }

        }
        
        public class TestSettings
        {

        }


        public static RunSettings initRunSettings()
        {
            SettingsClasses.RunSettings runSettings = new SettingsClasses.RunSettings();
            if (Properties.Settings.Default.buttonTriggerToggle)
            {
                runSettings.TriggerType = 1;
            }
            else if (Properties.Settings.Default.audioTriggerToggle)
            {
                runSettings.TriggerType = 2;
            }
            else if (Properties.Settings.Default.pinTriggerToggle)
            {
                runSettings.TriggerType = 3;
            }
            if (Properties.Settings.Default.lightSensorToggle)
            {
                runSettings.SensorType = 1;
            }
            else if (Properties.Settings.Default.audioSensorToggle)
            {
                runSettings.SensorType = 2;
            }
            if (Properties.Settings.Default.directXToggle)
            {
                runSettings.SourceType = 1;
            }
            else if (Properties.Settings.Default.gameExternalToggle)
            {
                runSettings.SourceType = 2;
            }
            else if (Properties.Settings.Default.audioSourceToggle)
            {
                runSettings.SourceType = 3;
            }
            runSettings.PreTest = Properties.Settings.Default.preTestToggle;
            return runSettings;
        }
    }
}
