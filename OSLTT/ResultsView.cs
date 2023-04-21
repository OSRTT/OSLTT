using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OSLTT
{
    public partial class ResultsView : MaterialForm
    {
        public string resultsFolderPath = "";

        public ResultsView()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void setResultsFolder(string p)
        {
            resultsFolderPath = p;
        }

        public void inputLagMode(ProcessData.averagedInputLag il)
        {

        }

        public void importMode()
        {
            Size = new Size(720, 156);
            importPanel.Visible = true;
            importPanel.BringToFront();
            barPlot.Visible = false;
            barPlot.SendToBack();
            controlsPanel.Visible = false;
            controlsPanel.SendToBack();
        }

        public void graphMode()
        {
            Size = new Size(1222, 829);
            importPanel.Visible = false;
            importPanel.SendToBack();
            barPlot.Visible = true;
            barPlot.BringToFront();
            controlsPanel.Visible = true;
            controlsPanel.BringToFront();
        }

        private void savePNGBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveWhitePNGBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
