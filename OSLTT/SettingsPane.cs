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
    // TODO  - write functions to fill the selects!!!!
    public partial class SettingsPane : UserControl
    {
        public SettingsPane()
        {
            InitializeComponent();
            CheckBoardType();
            /*isolateLabel.Visible = false;
            preTestToggle.Checked = false;
            preTestToggle.Enabled = false;
            preTestToggle.Visible = false;*/
            listMonitors();
            FillSelects();
            if (Properties.Settings.Default.customTestSettings != null)
            {
                testSettings = Properties.Settings.Default.customTestSettings;
                if (testSettings.TriggerType >= 3)
                {
                    testSettings.TriggerType = 2;
                }
                ChangeSettings(
                    testSettings.TriggerType,
                    testSettings.SensorType,
                    testSettings.TestSource,
                    testSettings.AutoClick,
                    testSettings.ClickCount,
                    testSettings.TimeBetween,
                    testSettings.PreTest,
                    testSettings.MouseAction,
                    testSettings.TwoPinTrigger
                    );
            }
            else
            {
                MonitorPreset();
            }
        }

        TestSettings testSettings = new TestSettings();
        public Main mainWindow;

        public void CheckBoardType(int BoardType = 0)
        {
            if (BoardType == 1)
            {
                if (triggerSelect.Items.Count != 4)
                {
                    this.triggerSelect.Invoke((MethodInvoker)(() => this.triggerSelect.Items.Add("Tap Input")));
                    this.triggerSelect.Invoke((MethodInvoker)(() => this.triggerSelect.Items.Add("Mic (High Sense)")));
                }
                if (testSelect.Items.Count != 8)
                {
                    this.testSelect.Invoke((MethodInvoker)(() => this.testSelect.Items.Add("Mouse Move")));
                }
            }
            else
            {
                int triggerIndex = 0;
                int testIndex = 0;
                try
                {
                    this.triggerSelect.Invoke((MethodInvoker)(() => triggerIndex = this.triggerSelect.SelectedIndex));
                    this.testSelect.Invoke((MethodInvoker)(() => testIndex = this.testSelect.SelectedIndex));
                }
                catch { }
                if (triggerSelect.Items.Count == 4)
                {
                    this.triggerSelect.Invoke((MethodInvoker)(() => this.triggerSelect.Items.RemoveAt(3)));
                    this.triggerSelect.Invoke((MethodInvoker)(() => this.triggerSelect.Items.RemoveAt(3)));
                }
                if (triggerIndex >= 3)
                {
                    this.triggerSelect.Invoke((MethodInvoker)(() => this.triggerSelect.SelectedIndex = 2));
                    try
                    {
                        this.triggerSelect.Invoke((MethodInvoker)(() => this.triggerSelect.Refresh()));
                    }
                    catch { }
                }
                if (testSelect.Items.Count == 8)
                {
                    this.testSelect.Invoke((MethodInvoker)(() => this.testSelect.Items.RemoveAt(7)));
                }
                if (testIndex == 7)
                {
                    this.testSelect.Invoke((MethodInvoker)(() => this.testSelect.SelectedIndex = 1));
                    try
                    {
                        this.testSelect.Invoke((MethodInvoker)(() => this.testSelect.Refresh()));
                    }
                    catch { }
                }
            }
        }

        public void SaveSettings()
        {
            // Make this delegate in case it's called from another thread
            
            testSettings.TriggerType = triggerSelect.SelectedIndex + 1;
            testSettings.SensorType = sensorSelect.SelectedIndex + 1;
            testSettings.TestSource = testSelect.SelectedIndex + 1;
            testSettings.AutoClick = autoClickToggle.Checked;
            testSettings.ClickCount = int.Parse(clickCountSelect.Items[clickCountSelect.SelectedIndex].ToString());
            testSettings.PreTest = preTestToggle.Checked;
            testSettings.TimeBetween = double.Parse(timeBetweenSelect.Items[timeBetweenSelect.SelectedIndex].ToString());
            Properties.Settings.Default.customTestSettings = testSettings;
            Properties.Settings.Default.Save();

            if (testSettings.TestSource != 1)
            {
                displayCard.Enabled = false;
            }
            else
            {
                displayCard.Enabled = true;
            }
            if (autoClickToggle.Checked || testSettings.AutoClick)
            {
                clickCountSelect.Enabled = true;
                timeBetweenSelect.Enabled = true;
            }
            else
            {
                clickCountSelect.Enabled = false;
                timeBetweenSelect.Enabled = false;
            }
            if (mainWindow != null) // move this to separate function?
            {
                int autoClick = 0;
                if (testSettings.AutoClick)
                {
                    autoClick = 1;
                }
                int trigger = testSettings.TriggerType;
                if (trigger == 3)
                {
                    trigger += testSettings.TwoPinTrigger;
                }
                else if (trigger == 4)
                {
                    trigger++; // skip over 4 as two pin mode uses it
                }
                string settings = "I";
                settings += testSettings.SensorType.ToString();
                settings += trigger.ToString();
                settings += autoClick.ToString();
                settings += testSettings.TestSource.ToString();
                int clicks = testSettings.ClickCount / 10;
                settings += clicks.ToString("00");
                double t = testSettings.TimeBetween;
                if (t == 0.5) { settings += "1"; }
                else { t += 1; settings += t.ToString(); }
                settings += testSettings.MouseAction.ToString();
                //settings += "1";
                Console.WriteLine(settings);
                mainWindow.portWrite(settings);

                mainWindow.testSettings = testSettings;
                // maybe change these settings? change directX to source
            }
            this.Refresh();
        }
        private void FillSelects()
        {
            triggerSelect.Items.Clear();
            triggerSelect.Items.Add("OSLTT Button");
            triggerSelect.Items.Add("Audio Jack (Mic)");
            triggerSelect.Items.Add("2 Pin Input");

            sensorSelect.Items.Clear();
            sensorSelect.Items.Add("Light Sensor");
            sensorSelect.Items.Add("Audio Sensor");
            sensorSelect.Items.Add("Clicks/Keypresses");

            testSelect.Items.Clear();
            testSelect.Items.Add("DirectX Tool");
            testSelect.Items.Add("Mouse (Click)");
            testSelect.Items.Add("Game");
            testSelect.Items.Add("Audio Clip");
            testSelect.Items.Add("External");
            testSelect.Items.Add("Keyboard");
            testSelect.Items.Add("Gamepad/Controller");
            //testSelect.Items.Add("Mouse Move");
        }

        public class Displays
        {
            public string Name { get; set; }
            public int Freq { get; set; }
            public string Resolution { get; set; }
            public string Connection { get; set; }
            public string ManufacturerCode { get; set; }
            public string EDIDModel { get; set; }
            public int DisplayNumber { get; set; }
        }
        public List<Displays> displayList = new List<Displays>();

        public Displays selectedDisplay;

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
                        var data = new Displays { Name = name, Freq = refresh, Resolution = res, Connection = con, ManufacturerCode = manCode, EDIDModel = edidCode, DisplayNumber = displayList.Count() };
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
            selectedDisplay = displayList[selected];
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
            ChangeSettings(1, 1, 1, true, 100, 0.5, false, 0, 0);
            EnableDisable(false, false, false, true, true, false);
        }

        public void MouseKeyboardPreset()
        {
            // disable all settings
            // mouse/keyboard sensor
            // clicks/keypress source
            // audio jack trigger
            ChangeSettings(2, 3, 2, false, 100, 0.5, false, 0, 0);
            EnableDisable(false, false, false, false, false, false);
        }
        public void KeyboardPreset()
        {
            // disable all settings
            // mouse/keyboard sensor
            // clicks/keypress source
            // audio jack trigger
            ChangeSettings(2, 3, 6, false, 100, 0.5, false, 0, 0);
            EnableDisable(false, false, false, false, false, false);
        }
        public void GamepadPreset()
        {
            // disable all settings
            // mouse/keyboard sensor
            // clicks/keypress source
            // audio jack trigger
            ChangeSettings(2, 3, 7, false, 100, 0.5, false, 0, 0);
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
            ChangeSettings(1, 1, 3, true, 100, 0.5, true, 0, 0);
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
            ChangeSettings(1, 2, 4, true, 30, 1, false, 0, 0);
            EnableDisable(false, false, false, true, false, false);
        }

        public void ConsolePreset()
        {
            
            ChangeSettings(2, 1, 5, false, 100, 1, false, 0, 0);
            EnableDisable(false, false, false, false, false, false);
        }

        public void CustomPreset1()
        {
            // set to monitor settings then enable everything
            if (Properties.Settings.Default.customTestSettings != null)
            {
                testSettings = Properties.Settings.Default.customTestSettings;
                ChangeSettings(
                    testSettings.TriggerType,
                    testSettings.SensorType,
                    testSettings.TestSource,
                    testSettings.AutoClick,
                    testSettings.ClickCount,
                    testSettings.TimeBetween,
                    testSettings.PreTest,
                    testSettings.MouseAction,
                    testSettings.TwoPinTrigger
                    );
            }
            else
            {
                ChangeSettings(1, 1, 1, true, 100, 0.5, false, 0, 0);
            }
            EnableDisable(true, true, true, true, true, false);
        }

        public void ChangeSettings(int trigger, int sensor, int source, bool autoClick, int clicks, double time, bool pretest, int mouseAction, int twoPinTrigger)
        {
            SetComboBoxValue(clickCountSelect, clicks);
            SetComboBoxValue(timeBetweenSelect, time);
            if (trigger == 4 && triggerSelect.Items.Count < 4)
            {
                trigger = 3;
            }
            if (source == 8 && testSelect.Items.Count < 8)
            {
                source = 2;
            }

            if (this.InvokeRequired)
            {
                triggerSelect.Invoke((MethodInvoker)(() => triggerSelect.SelectedIndex = trigger - 1));
                sensorSelect.Invoke((MethodInvoker)(() => sensorSelect.SelectedIndex = sensor - 1));
                testSelect.Invoke((MethodInvoker)(() => testSelect.SelectedIndex = source - 1));
                autoClickToggle.Invoke((MethodInvoker)(() => autoClickToggle.Checked = autoClick));
                preTestToggle.Invoke((MethodInvoker)(() => preTestToggle.Checked = pretest));
                mouseActionSelect.Invoke((MethodInvoker)(() => mouseActionSelect.SelectedIndex = mouseAction));
                twoPinTriggerSelect.Invoke((MethodInvoker)(() => twoPinTriggerSelect.SelectedIndex = twoPinTrigger));
            }
            else
            {
                triggerSelect.SelectedIndex = trigger - 1;
                sensorSelect.SelectedIndex = sensor - 1;
                testSelect.SelectedIndex = source - 1;
                autoClickToggle.Checked = autoClick;
                preTestToggle.Checked = pretest;
                mouseActionSelect.SelectedIndex = mouseAction;
                twoPinTriggerSelect.SelectedIndex = twoPinTrigger;
            }
            testSettings.AutoClick = autoClick;
            testSettings.ClickCount = clicks;
            testSettings.PreTest = pretest;
            testSettings.SensorType = sensor;
            testSettings.TestSource = source;
            testSettings.TimeBetween = time;
            testSettings.TriggerType = trigger;
            testSettings.MouseAction = mouseAction;
            testSettings.TwoPinTrigger = twoPinTrigger;
            this.Invalidate();
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
                this.settingsCard.Invoke((MethodInvoker)(() => this.settingsCard.Enabled = settingsCard));
                this.displayCard.Invoke((MethodInvoker)(() => this.displayCard.Enabled = displayCard));
                this.preTestToggle.Invoke((MethodInvoker)(() => this.preTestToggle.Enabled = pretest));
            }
            else
            {
                this.triggerCard.Enabled = triggerCard;
                this.settingsCard.Enabled = settingsCard;
                this.displayCard.Enabled = displayCard;
                this.preTestToggle.Enabled = pretest;
            }
        }

        

       

        private void autoClickToggle_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSwitch s = sender as MaterialSwitch;
            if (s.Focused)
            {
                if (s.Checked)
                {
                    testSettings.AutoClick = s.Checked;
                    if (testSettings.TriggerType != 1)
                    {
                        triggerSelect.SelectedIndex = 0;
                    }
                    if (testSettings.SensorType == 3)
                    {
                        sensorSelect.SelectedIndex = 0;
                    }
                    if (testSettings.TestSource == 2)
                    {
                        testSelect.SelectedIndex = 0;
                    }
                }
                SaveSettings();
            }
        }

        private void clickCountSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.ClickCount = int.Parse(s.Items[s.SelectedIndex].ToString());
                SaveSettings();
            }
        }

        private void timeBetweenSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.TimeBetween = double.Parse(s.Items[s.SelectedIndex].ToString());
                SaveSettings();
            }
        }

        private void preTestToggle_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSwitch s = sender as MaterialSwitch;
            if (s.Focused)
            {
                if (s.Checked)
                {
                    testSettings.PreTest = s.Checked;
                    if (testSettings.TriggerType != 1)
                    {
                        triggerSelect.SelectedIndex = 0;
                    }
                    if (testSettings.SensorType != 1)
                    {
                        sensorSelect.SelectedIndex = 0;
                    }
                    if (testSettings.TestSource != 3)
                    {
                        testSelect.SelectedIndex = 2;
                    }
                }
                SaveSettings();
            }
        }

        private void displaySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                if (selectedDisplay != displayList[s.SelectedIndex])
                {
                    selectedDisplay = displayList[s.SelectedIndex];
                    if (mainWindow.systemLagData.inputLagResults != null)
                    {
                        mainWindow.systemLagData = new ProcessData.averagedInputLag();
                        // message box to say system lag data cleared due to display change?
                        mainWindow.pretestButtonState();
                    }
                }

            }
        }

        private void refreshMonitorsBtn_Click(object sender, EventArgs e)
        {
            listMonitors();
        }

        

        private void mouseActionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.MouseAction = s.SelectedIndex;
                SaveSettings();
            }
        }

        

        private void twoPinTriggerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.TwoPinTrigger = s.SelectedIndex;
                SaveSettings();
            }
        }

        private void triggerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.TriggerType = s.SelectedIndex + 1;
                if (s.SelectedIndex == 0) // button
                {
                    // Only works with Light or Audio
                    if (testSettings.SensorType != 1 && testSettings.SensorType != 2 )
                    {
                        sensorSelect.SelectedIndex = 0;
                    }
                    // Only works with DirectX, Game, Audio
                    if (testSettings.TestSource != 1 && testSettings.TestSource != 3 && testSettings.TestSource != 4)
                    {
                        testSelect.SelectedIndex = 0;
                    }
                }
                else if (s.SelectedIndex == 1) // Audio Jack
                {
                    // Only works with Light or Clicks
                    if (testSettings.SensorType != 1 && testSettings.SensorType != 3)
                    {
                        sensorSelect.SelectedIndex = 2; // set to clicks by default
                    }
                    // Only works with Mouse click, game, keyboard or controller
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 3 && testSettings.TestSource != 5 && testSettings.TestSource != 6 && testSettings.TestSource != 7)
                    {
                        testSelect.SelectedIndex = 1; // set to mouse by default
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                    if (autoClickToggle.Checked)
                    {
                        autoClickToggle.Checked = false;
                    }
                }
                else if (s.SelectedIndex == 2) // 2 pin
                {
                    // Only works with light and clicks
                    if (testSettings.SensorType != 1 && testSettings.SensorType != 3)
                    {
                        sensorSelect.SelectedIndex = 2; // set to clicks as default
                    }
                    // Only works with Mouse click, external, keyboard, controller
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 5 && testSettings.TestSource != 6 && testSettings.TestSource != 7)
                    {
                        if (testSettings.SensorType == 1) // if light sensor, set external
                        {
                            testSelect.SelectedIndex = 4;
                        }
                        else
                        {
                            testSelect.SelectedIndex = 1; // Set to mouse as default
                        }
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                }
                else if (s.SelectedIndex == 3) // 3 pin
                {
                    // Only works with clicks
                    if (testSettings.SensorType != 3)
                    {
                        sensorSelect.SelectedIndex = 2; // set to clicks as default
                    }
                    // Only works with Mouse click,  keyboard, controller and mouse mouse
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 6 && testSettings.TestSource != 7 && testSettings.TestSource != 8)
                    {
                        testSelect.SelectedIndex = 1; // Set to mouse as default
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                }
                else if (s.SelectedIndex == 4) // high sensitivity mic
                {
                    // Only works with Light or Clicks
                    if (testSettings.SensorType != 1 && testSettings.SensorType != 3)
                    {
                        sensorSelect.SelectedIndex = 2; // set to clicks by default
                    }
                    // Only works with Mouse click, game, keyboard or controller
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 3 && testSettings.TestSource != 5 && testSettings.TestSource != 6 && testSettings.TestSource != 7)
                    {
                        testSelect.SelectedIndex = 1; // set to mouse by default
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                    if (autoClickToggle.Checked)
                    {
                        autoClickToggle.Checked = false;
                    }
                }
                SaveSettings();
            }
        }

        private void sensorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.SensorType = s.SelectedIndex + 1;
                if (s.SelectedIndex == 0) // light
                {
                    // Only works with button, mic and 2 pin
                    if (testSettings.TriggerType != 1 && testSettings.TriggerType != 2 && testSettings.TriggerType != 3)
                    {
                        triggerSelect.SelectedIndex = 0; // set to button by default   
                    }
                    // Only works with DirectX, game and external
                    if (testSettings.TestSource != 1 && testSettings.TestSource != 3 && testSettings.TestSource != 5)
                    {
                        if (testSettings.TriggerType == 3) // if 2pin, set to external
                        {
                            testSelect.SelectedIndex = 4; // set external
                        }
                        else
                        {
                            testSelect.SelectedIndex = 0; // set to DirectX by default
                        }
                    }
                }
                else if (s.SelectedIndex == 1) // audio
                {
                    // Only works with button
                    if (testSettings.TriggerType != 1)
                    {
                        triggerSelect.SelectedIndex = 0; // set to button
                    }
                    // Only works with audio
                    if (testSettings.TestSource != 4)
                    {
                        testSelect.SelectedIndex = 3; // set to audio
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                }
                else if (s.SelectedIndex == 2) // clicks
                {
                    // Only works with Mic, 2 pin and 3 pin
                    if (testSettings.TriggerType != 2 && testSettings.TriggerType != 3 && testSettings.TriggerType != 4)
                    {
                        triggerSelect.SelectedIndex = 1; // set to clicks by default
                    }
                    // Only works with mouse, keyboard and controller
                    if (testSettings.TestSource != 2 && testSettings.TestSource != 6 && testSettings.TestSource != 7)
                    {
                        testSelect.SelectedIndex = 1; // set to mouse by default
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                    if (autoClickToggle.Checked)
                    {
                        autoClickToggle.Checked = false;
                    }
                }
                SaveSettings();
            }
        }

        private void testSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialComboBox s = sender as MaterialComboBox;
            if (s.Focused)
            {
                testSettings.TestSource = s.SelectedIndex + 1;
                if (s.SelectedIndex == 0) // DirectX
                {
                    // Only works with button
                    if (testSettings.TriggerType != 1)
                    {
                        triggerSelect.SelectedIndex = 0; // set to button
                    }
                    // Only works with light
                    if (testSettings.SensorType != 1)
                    {
                        sensorSelect.SelectedIndex = 0; // set to directx
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }
                }
                else if (s.SelectedIndex == 1 || s.SelectedIndex == 5 || s.SelectedIndex == 6) // Mouse (clicks), Keyboard, Gamepad
                {
                    // only works with mic, 2 pin, 3 pin
                    if (testSettings.TriggerType != 2 && testSettings.TriggerType != 3 && testSettings.TriggerType != 4)
                    {
                        triggerSelect.SelectedIndex = 1; // set to mic by default
                    }
                    // only works with clicks
                    if (testSettings.SensorType != 3)
                    {
                        sensorSelect.SelectedIndex = 2; // set to clicks by default
                    }
                    if (autoClickToggle.Checked)
                    {
                        autoClickToggle.Checked = false;
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }

                }
                else if (s.SelectedIndex == 2) // Game
                {
                    // Only works with button and mic
                    if (testSettings.TriggerType != 1 && testSettings.TriggerType != 2)
                    {
                        triggerSelect.SelectedIndex = 0; // set to button by default
                    }
                    // only works with light
                    if (testSettings.SensorType != 1)
                    {
                        sensorSelect.SelectedIndex = 0; // set to light
                    }
                }
                else if (s.SelectedIndex == 3) // Audio
                {
                    // Only works with button
                    if (testSettings.TriggerType != 1)
                    {
                        triggerSelect.SelectedIndex = 0; // set to button
                    }
                    // Only works with mic
                    if (testSettings.SensorType != 2)
                    {
                        sensorSelect.SelectedIndex = 1; // set to mic
                    }
                    if (preTestToggle.Checked)
                    {
                        preTestToggle.Checked = false;
                    }

                }
                else if (s.SelectedIndex == 4) // External
                {
                    // Only works with 2 pin
                    if (testSettings.TriggerType != 3)
                    {
                        triggerSelect.SelectedIndex = 2; // set to 2 pin
                    }
                    // Only works with light
                    if (testSettings.SensorType != 1)
                    {
                        sensorSelect.SelectedIndex = 0; // set to light
                    }
                }
                SaveSettings();
            }
        }
    }
}
