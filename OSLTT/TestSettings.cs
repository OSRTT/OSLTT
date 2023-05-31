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

        public int TriggerTypes(MaterialRadioButton button, MaterialRadioButton audio)
        {
            if (button.Checked)
            {
                return 1;
            }
            else if (audio.Checked)
            {
                return 2;
            }
            else
            {
                return 3;
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
                return 3;
            }
        }

        public int SourceTypes(MaterialRadioButton directx, MaterialRadioButton mouse, MaterialRadioButton game)
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
            else
            {
                return 4;
            }
        }

    }
}
