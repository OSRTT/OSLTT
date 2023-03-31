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
    public partial class Main : Form
    {
        private List<float> inputLagEvents = new List<float>();


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void getInputLagEvents(List<float> fpsList)
        {
            inputLagEvents = fpsList;
            //Console.WriteLine(fpsList.Average().ToString());
        }
    }
}
