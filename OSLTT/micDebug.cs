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
    public partial class micDebug : Form
    {
        public micDebug()
        {
            InitializeComponent();
        }

        private void micDebug_Load(object sender, EventArgs e)
        {
            showData(mainData);
        }

        public List<int> mainData;

        public void showData(List<int> data)
        {
            try
            {
                mainData = data;
                List<double[]> arrays = new List<double[]>();
                int arrSize = data.Count;
                double[] xs = new double[arrSize];
                double[] ys = new double[arrSize];

                for (int i = 0; i < arrSize; i++)
                {
                    xs[i] = i;

                    ys[i] = data[i];

                }
                formsPlot1.Plot.AddSignal(ys);
                formsPlot1.Plot.Render();
                formsPlot1.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        
    }
}
