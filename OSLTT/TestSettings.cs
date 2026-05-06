using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace OSLTT
{
    public class TestSettings
    {
        public string Name { get; set; }
        public int TriggerType { get; set; }
        public int SensorType { get; set; }
        public int TestSource { get; set; }
        public bool AutoClick { get; set; }
        public int ClickCount { get; set; }
        public double TimeBetween { get; set; }
        public bool PreTest { get; set; }
        public int MouseAction { get; set; }
        public int TwoPinTrigger { get; set; }

        public ProcessData.resultType ResultType { get; set; }

        public enum TriggerTypes
        {
            Button = 1,
            Mic = 2,
            TwoPin = 3,
            Tap = 4,
            HighGainMic = 5
        }

        public enum SensorTypes
        {
            Light = 1,
            Audio = 2,
            Clicks = 3
        }

        public enum TestSources
        {
            DirectX = 1,
            MouseClick = 2,
            Game = 3,
            Audio = 4,
            External = 5,
            Keyboard = 6,
            Controller = 7,
            MouseMove = 8
        }

        public class ConfigSetting
        {
            public TriggerTypes Trigger { get; set; }
            public SensorTypes Sensor { get; set; }
            public TestSources Source { get; set; }

            public ConfigSetting(TriggerTypes t, SensorTypes s, TestSources src)
            {
                Trigger = t;
                Sensor = s;
                Source = src;
            }

            // Override Equals to make comparison easy
            public override bool Equals(object obj)
            {
                if (!(obj is ConfigSetting other)) return false;
                return Trigger == other.Trigger && Sensor == other.Sensor && Source == other.Source;
            }

            public override int GetHashCode() => (Trigger, Sensor, Source).GetHashCode();
        }

        public static class ConfigValidator
        {
            private static readonly List<ConfigSetting> AllowedConfigs = new List<ConfigSetting>
            {
                new ConfigSetting(TriggerTypes.Button, SensorTypes.Light, TestSources.DirectX),
                new ConfigSetting(TriggerTypes.Button, SensorTypes.Light, TestSources.Game),
                new ConfigSetting(TriggerTypes.Button, SensorTypes.Audio, TestSources.Audio),

                new ConfigSetting(TriggerTypes.Mic, SensorTypes.Light, TestSources.Game),
                new ConfigSetting(TriggerTypes.Mic, SensorTypes.Light, TestSources.External),
                new ConfigSetting(TriggerTypes.Mic, SensorTypes.Clicks, TestSources.MouseClick),
                //new ConfigSetting(TriggerTypes.Mic, SensorTypes.Clicks, TestSources.MouseMove),
                new ConfigSetting(TriggerTypes.Mic, SensorTypes.Clicks, TestSources.Keyboard),
                new ConfigSetting(TriggerTypes.Mic, SensorTypes.Clicks, TestSources.Controller),

                new ConfigSetting(TriggerTypes.HighGainMic, SensorTypes.Light, TestSources.Game),
                new ConfigSetting(TriggerTypes.HighGainMic, SensorTypes.Light, TestSources.External),
                new ConfigSetting(TriggerTypes.HighGainMic, SensorTypes.Clicks, TestSources.MouseClick),
                //new ConfigSetting(TriggerTypes.HighGainMic, SensorTypes.Clicks, TestSources.MouseMove),
                new ConfigSetting(TriggerTypes.HighGainMic, SensorTypes.Clicks, TestSources.Keyboard),
                new ConfigSetting(TriggerTypes.HighGainMic, SensorTypes.Clicks, TestSources.Controller),

                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Light, TestSources.Game),
                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Light, TestSources.External),
                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Audio, TestSources.Game),
                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Audio, TestSources.External),
                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Clicks, TestSources.MouseClick),
                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Clicks, TestSources.Keyboard),
                new ConfigSetting(TriggerTypes.TwoPin, SensorTypes.Clicks, TestSources.Controller),

                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Light, TestSources.Game),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Light, TestSources.External),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Audio, TestSources.Game),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Audio, TestSources.External),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Clicks, TestSources.MouseClick),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Clicks, TestSources.MouseMove),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Clicks, TestSources.Keyboard),
                new ConfigSetting(TriggerTypes.Tap, SensorTypes.Clicks, TestSources.Controller),

            };

            // The Global Default if everything goes wrong
            private static readonly ConfigSetting DefaultFallback =
                new ConfigSetting(TriggerTypes.Button, SensorTypes.Light, TestSources.DirectX);

            public static bool IsAllowed(TriggerTypes t, SensorTypes s, TestSources src)
            {
                return AllowedConfigs.Any(c => c.Trigger == t && c.Sensor == s && c.Source == src);
            }

            public static ConfigSetting ResolveConfiguration(TriggerTypes t, SensorTypes s, TestSources src, Type defaultType, int boardType = 1)
            {
                // 1. Check if the current selection is already valid
                if (IsAllowed(t, s, src))
                    return new ConfigSetting(t, s, src);
                IEnumerable<ConfigSetting> candidates = AllowedConfigs;
                // 2. Attempt to keep the Trigger and find the first valid Sensor/Source for it
                if (boardType == 0)
                {
                    candidates = candidates.Where(c =>
                        c.Trigger != TriggerTypes.HighGainMic &&
                        c.Trigger != TriggerTypes.Tap);
                }
                if (defaultType == typeof(TriggerTypes))
                {
                    candidates = AllowedConfigs.Where(c => c.Trigger == t);
                }
                else if (defaultType == typeof(SensorTypes))
                {
                    candidates = AllowedConfigs.Where(c => c.Sensor == s);
                }
                else
                {
                    candidates = AllowedConfigs.Where(c => c.Source == src);
                }
                var bestMatch = candidates
                    .OrderByDescending(c =>
                        (c.Trigger == t ? 1 : 0) +
                        (c.Sensor == s ? 1 : 0) +
                        (c.Source == src ? 1 : 0))
                    .FirstOrDefault();

                if (bestMatch != null)
                    return bestMatch;
                
                // If all else fails, return the hard-coded system default.
                return DefaultFallback;
            }
        }
        /*public int TriggerTypes(MaterialRadioButton button, MaterialRadioButton audio, MaterialRadioButton twoPin)
        {
            if (button.Checked)
            {
                return 1;
            }
            else if (audio.Checked)
            {
                return 2;
            }
            else if (twoPin.Checked)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public int SensorTypes(MaterialRadioButton light, MaterialRadioButton audio)
        {
            if (light.Checked)
            {
                return 1;
            }
            else if (audio.Checked)
            {
                return 2;
            }
            else
            {
                return 3; // clicks
            }
        }

        public int SourceTypes(MaterialRadioButton directx, MaterialRadioButton mouse, MaterialRadioButton keyboard, MaterialRadioButton game, MaterialRadioButton audio, MaterialRadioButton external)
        {
            if (directx.Checked)
            {
                return 1;
            }
            else if (mouse.Checked)
            {
                return 2;
            }
            else if (game.Checked)
            {
                return 3;
            }
            else if (audio.Checked)
            {
                return 4;
            }
            else if (external.Checked)
            {
                return 5;
            }
            else if (keyboard.Checked)
            {
                return 6;
            }
            else
            {
                return 7; // Controller
            }
        }*/

        public ProcessData.resultType GetResultType(int SensorType)
        {
            if (SensorType == 1)
            {
                return ProcessData.resultType.Light;
            }
            else if (SensorType == 2)
            {
                return ProcessData.resultType.Audio;
            }
            else
            {
                return ProcessData.resultType.Click;
            }
        }

    }
}
