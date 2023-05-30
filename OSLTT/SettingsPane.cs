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
        public Main mainWindow;

        private void SaveSettings(int sensor = 1, int trigger = 1, int autoClick = 1, int directX = 1, int clicks = 100, double time = 0.5)
        {
            if (mainWindow != null)
            {
                string settings = "I";
                settings += sensor.ToString();
                settings += trigger.ToString();
                settings += autoClick.ToString();
                settings += directX.ToString();
                clicks = Properties.Settings.Default.clickCountSelect / 10;
                settings += clicks.ToString("00");
                double t = Properties.Settings.Default.timeBetweenSelect;
                if (t == 0.5) { settings += "1"; }
                else { t += 1; settings += t.ToString(); }
                Console.WriteLine(settings);
                mainWindow.portWrite(settings);

                // maybe change these settings? change directX to source
            }
        }
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
            ChangeSettings(1, 1, 1, true, 100, 0.5, false);
            EnableDisable(false, false, false, true, true, false);
        }

        public void MouseKeyboardPreset()
        {
            // disable all settings
            // mouse/keyboard sensor
            // clicks/keypress source
            // audio jack trigger
            ChangeSettings(2, 3, 2, false, 100, 0.5, false);
            EnableDisable(false, false, false, false, false, false);
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
            ChangeSettings(1, 1, 3, true, 100, 0.5, true);
            EnableDisable(false, false, false, true, false, false);
        }

        public void AudioPreset()
        {
            // button trigger
            // audio sensor
            // auto click enabled
            // pretest disabled (for now)
            // display disabled
            // audio clip source
            ChangeSettings(1, 2, 4, true, 30, 1, false);
            EnableDisable(false, false, false, true, false, false);
        }

        public void CustomPreset1()
        {
            // set to monitor settings then enable everything
            ChangeSettings(1, 1, 1, true, 100, 0.5, false);
            EnableDisable(true, true, true, true, true, true);
        }

        public void ChangeSettings(int trigger, int sensor, int source, bool autoClick, int clicks, double time, bool pretest)
        {
            MaterialRadioButton triggerType;
            MaterialRadioButton sensorType;
            MaterialRadioButton sourceType;
            if (trigger == 1)
            {
                triggerType = buttonTriggerRadio;
            }
            else if (trigger == 2)
            {
                triggerType = audioTriggerRadio;
            }
            else
            {
                triggerType = twoPinRadio;
            }
            if (sensor == 1)
            {
                sensorType = lightSensorRadio;
            }
            else if (sensor == 2)
            {
                sensorType = audioSensorRadio;
            }
            else
            {
                sensorType = clickKeypressRadio;
            }
            if (source == 1)
            {
                sourceType = DirectXRadio;
            }
            else if (source == 2)
            {
                sourceType = mouseKeyboardRadio;
            }
            else if (source == 3)
            {
                sourceType = gameExternalRadio;
            }
            else
            {
                sourceType = audioSourceRadio;
            }
            
            SetComboBoxValue(clickCountSelect, clicks);
            SetComboBoxValue(timeBetweenSelect, time);

            if (this.InvokeRequired)
            {
                triggerType.Invoke((MethodInvoker)(() => triggerType.Checked = true));
                sensorType.Invoke((MethodInvoker)(() => sensorType.Checked = true));
                sourceType.Invoke((MethodInvoker)(() => sourceType.Checked = true));
                autoClickToggle.Invoke((MethodInvoker)(() => autoClickToggle.Checked = autoClick));
                preTestToggle.Invoke((MethodInvoker)(() => preTestToggle.Checked = pretest));
            }
            else
            {
                triggerType.Checked = true;
                sensorType.Checked = true;
                sourceType.Checked = true;
                autoClickToggle.Checked = autoClick;
                preTestToggle.Checked = pretest;
            }
            testSettings.AutoClick = autoClick;
            testSettings.ClickCount = clicks;
            testSettings.PreTest = pretest;
            testSettings.SensorType = sensor;
            testSettings.TestSource = source;
            testSettings.TimeBetween = time;
            testSettings.TriggerType = trigger;
        }

        private void SetComboBoxValue(MaterialComboBox mcb, double value)
        {
            for (int i = 0; i < mcb.Items.Count; i++)
            {
                if (mcb.Items[i].ToString() == value.ToString())
                {
                    if (mcb.InvokeRequired)
                    {
                        mcb.Invoke((MethodInvoker)(() => mcb.SelectedIndex = i));
                    }
                    else
                    {
                        mcb.SelectedIndex = i;
                    }
                    break;
                }
            }
        }

        public void EnableDisable(bool triggerCard, bool sensorCard, bool sourceCard, bool settingsCard, bool displayCard, bool pretest)
        {
            if (this.InvokeRequired)
            {
                this.triggerCard.Invoke((MethodInvoker)(() => this.triggerCard.Enabled = triggerCard));
                this.sensorCard.Invoke((MethodInvoker)(() => this.sensorCard.Enabled = sensorCard));
                this.sourceCard.Invoke((MethodInvoker)(() => this.sourceCard.Enabled = sourceCard));
                this.settingsCard.Invoke((MethodInvoker)(() => this.settingsCard.Enabled = settingsCard));
                this.displayCard.Invoke((MethodInvoker)(() => this.displayCard.Enabled = displayCard));
                this.preTestToggle.Invoke((MethodInvoker)(() => this.preTestToggle.Enabled = pretest));
            }
            else
            {
                this.triggerCard.Enabled = triggerCard;
                this.sensorCard.Enabled = sensorCard;
                this.sourceCard.Enabled = sourceCard;
                this.settingsCard.Enabled = settingsCard;
                this.displayCard.Enabled = displayCard;
                this.preTestToggle.Enabled = pretest;
            }
        }

        private void buttonTriggerRadio_CheckedChanged(object sender, EventArgs e)
        {
            MaterialRadioButton s = sender as MaterialRadioButton;
            if (s.Focused)
            {
                if (s.Checked)
                {
                    testSettings.TriggerType = 1;
                    if (clickKeypressRadio.Checked)
                    {
                        lightSensorRadio.Checked = true;
                    }
                    if (mouseKeyboardRadio.Checked)
                    {
                        DirectXRadio.Checked = true;
                    }
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

        private void refreshMonitorsBtn_Click(object sender, EventArgs e)
        {
            listMonitors();
        }
    }
}
