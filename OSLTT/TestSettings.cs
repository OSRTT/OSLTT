using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        TestSettings Validate(TestSettings ts)
        {
            if (ts.TriggerType == 2)
            {
                if (ts.SensorType == 2)
                {
                    ts.SensorType = 1;
                }
                ts.AutoClick = false;
                if (ts.TestSource == 4)
                {
                    ts.TestSource = 1;
                }
            }
            else if (ts.TriggerType == 3)
            {

            }

            return ts;
        }
    }
}
