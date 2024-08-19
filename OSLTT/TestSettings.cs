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

        public int TriggerTypes(MaterialRadioButton button, MaterialRadioButton audio, MaterialRadioButton twoPin)
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
                return 3;
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
        }

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
