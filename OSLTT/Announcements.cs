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
using System.Threading;
using System.Diagnostics;

namespace OSLTT
{
    public partial class Announcements : MaterialForm
    {
        public UpdateHandler.AnnouncementText announcementText = new UpdateHandler.AnnouncementText { titleText = "Nothing to see here...", descriptionText = "No updates here!" };
        public Announcements()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.TopMost = true;

        }

        public void SetAnnouncement(UpdateHandler.AnnouncementText a)
        {
            announcementText = a;
            Title.Text = announcementText.titleText;
            Description.Text = announcementText.descriptionText;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/OSRTT/OSLTT/releases");
        }
    }
}
