using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    public partial class SettingsPane : UserControl
    {
        public SettingsPane()
        {
            InitializeComponent();
            listMonitors();
        }

        TestSettings testSettings = new TestSettings();

        public class Displays
        {
            public string Name { get; set; }
            public int Freq { get; set; }
            public string Resolution { get; set; }
            public string Connection { get; set; }
            public string ManufacturerCode { get; set; }
            public string EDIDModel { get; set; }
        }
        public List<Displays> displayList = new List<Displays>();

        private void listMonitors(int selected = 0)
        {
            displaySelect.Items.Clear(); // Clear existing array and list before filling them
            displayList.Clear();
            var i = WindowsDisplayAPI.Display.GetDisplays();

            foreach (var target in WindowsDisplayAPI.DisplayConfig.PathInfo.GetActivePaths())
            {
                foreach (var item in target.TargetsInfo)
                {
                    try
                    {
                        string con = "Other";
                        if (item.OutputTechnology.ToString() == "DisplayPortExternal")
                        {
                            con = "DP";
                        }
                        else if (item.OutputTechnology.ToString() == "HDMI")
                        {
                            con = "HDMI";
                        }
                        double refreshRate = item.FrequencyInMillihertz;
                        refreshRate /= 1000;
                        refreshRate = Math.Round(refreshRate, 0);
                        int refresh = (int)refreshRate;
                        string name = item.DisplayTarget.ToString();
                        string manCode = "";
                        if (name == "")
                        {
                            name = target.DisplaySource.ToString().Remove(0, 4);
                        }
                        else { manCode = item.DisplayTarget.EDIDManufactureCode; }
                        string res = "";
                        try
                        {
                            res = item.DisplayTarget.PreferredResolution.Width.ToString() + "x" + item.DisplayTarget.PreferredResolution.Height.ToString();
                        }
                        catch { }
                        if (res == "")
                        {
                            res = "Failed to Aquire";
                        }
                        string edidCode = item.DisplayTarget.EDIDProductCode.ToString();
                        var data = new Displays { Name = name, Freq = refresh, Resolution = res, Connection = con, ManufacturerCode = manCode, EDIDModel = edidCode };
                        displayList.Add(data);
                        displaySelect.Items.Add(name);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ex.StackTrace);
                    }
                }
            }
            displaySelect.SelectedIndex = selected; // Pre-select the primary display
        }

        public void MonitorPreset()
        {
            // button trigger
            // light sensor
            // auto click set (enabled)
            // clicks/time 100/0.5 (enabled)
            // pretest disabled
            // display enabled
            // directx (disabled)
        }

        public void MouseKeyboardPreset()
        {
            // disable all settings
            // mouse/keyboard sensor
            // clicks/keypress source
            // audio jack trigger
        }

        public void GamesPreset()
        {
            // button trigger
            // light sensor
            // auto click set (enabled)
            // clicks/time 100/0.5 (enabled)
            // pretest on (enabled)
            // display disabled
            // game/external (disabled)
        }

        public void AudioPreset()
        {
            // button trigger
            // audio sensor
            // auto click enabled
            // pretest disabled (for now)
            // display disabled
            // audio clip source
        }

        public void CustomPreset1()
        {
            // set to monitor settings then enable everything
        }

        private void buttonTriggerRadio_CheckedChanged(object sender, EventArgs e)
        {
            MaterialRadioButton s = sender as MaterialRadioButton;
            if (s.Focused)
            {
                if (s.Checked)
                {
                    
                }
                //SaveSettings();
            }
        }

        private void audioTriggerRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void twoPinRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lightSensorRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void audioSensorRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clickKeypressRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void autoClickToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clickCountSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timeBetweenSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preTestToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void displaySelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DirectXRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mouseKeyboardRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gameExternalRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void audioSourceRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
