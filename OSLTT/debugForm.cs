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

namespace OSLTT
{
    public partial class debugForm : MaterialForm
    {
        public Main mainWindow;
        public debugForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.HandleCreated += handleCreated;
            Thread updateThread = new Thread(new ThreadStart(UpdateLog));
            updateThread.Start();
        }

        public List<string> debugList = new List<string>();

        private void handleCreated(Object sender, EventArgs e)
        {
            
        }

        public void AddToLog(string s)
        {
            debugList.Add(s);
            /*if (debugBox.InvokeRequired)
            {
                this.debugBox.Invoke((MethodInvoker)(() => this.debugBox.Text = s + Environment.NewLine + this.debugBox.Text));
            }
            else
            {
                this.debugBox.Text = s + Environment.NewLine + this.debugBox.Text;
            }*/
        }

        private void UpdateLog()
        {
            int listSize = 0;
            while (true)
            {
                while (this.IsHandleCreated)
                {
                    if (listSize != debugList.Count)
                    {
                        for (int i = listSize; i < debugList.Count; i++)
                        {
                            this.debugBox.Invoke((MethodInvoker)(() => this.debugBox.Text = debugList[i] + Environment.NewLine + this.debugBox.Text));
                        }
                        listSize = debugList.Count();
                    }
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void testMicBtn_Click(object sender, EventArgs e)
        {
            if (mainWindow != null)
            {
                mainWindow.portWrite("W3");
            }
        }
    }
}
