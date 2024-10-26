using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSLTT
{
    public partial class ResultsSettings : MaterialForm
    {
        public ResultsSettings()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            axisColourSelect.Items.Clear();
            foreach (var i in AxisColours)
            {
                axisColourSelect.Items.Add(i.Text);
            }
            autoScreenshotSelect.Items.Clear();
            autoScreenshotSelect.Items.Add("Disabled");
            autoScreenshotSelect.Items.Add("Transparent");
            autoScreenshotSelect.Items.Add("White Background");
            graphViewSelect.Items.Clear();
            graphViewSelect.Items.Add("Bar Chart");
            graphViewSelect.Items.Add("Scatter Plot");
            for (int i = 0; i < AxisColours.Count; i++)
            {
                if (AxisColours[i].Colour == Properties.Settings.Default.chartTextColour)
                {
                    axisColourSelect.SelectedIndex = i;
                    break;
                }
            }
            autoScreenshotSelect.SelectedIndex = Properties.Settings.Default.autoSaveScreenshots;
            graphViewSelect.SelectedIndex = Properties.Settings.Default.defaultGraphView;
            yAxisSlider.Value = Properties.Settings.Default.yMax;

        }

        public class AxisColour
        {
            public string Text { get; set; }
            public Color Colour { get; set; }
        }
        public static List<AxisColour> AxisColours = new List<AxisColour> 
        { 
            new AxisColour { Text = "Black", Colour = Color.Black },
            new AxisColour { Text = "Grey", Colour = Color.Gray },
            new AxisColour { Text = "White", Colour = Color.White },
        };

        private void yAxisSlider_MouseUp(object sender, MouseEventArgs e)
        {
            var ctrl = sender as MaterialSlider;
            if (ctrl.Focused)
            {
                // Save new setting
                Properties.Settings.Default.yMax = ctrl.Value;
                Properties.Settings.Default.Save();
            }
        }

        private void axisColourSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ctrl = sender as MaterialComboBox;
            if (ctrl.Focused)
            {
                Properties.Settings.Default.chartTextColour = AxisColours[ctrl.SelectedIndex].Colour;
                Properties.Settings.Default.Save();
            }
        }

        private void graphViewSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ctrl = sender as MaterialComboBox;
            if (ctrl.Focused)
            {
                Properties.Settings.Default.defaultGraphView = ctrl.SelectedIndex;
                Properties.Settings.Default.Save();
            }
        }

        private void autoScreenshotSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ctrl = sender as MaterialComboBox;
            if (ctrl.Focused)
            {
                Properties.Settings.Default.autoSaveScreenshots = ctrl.SelectedIndex;
                Properties.Settings.Default.Save();
            }
        }
    }
}
