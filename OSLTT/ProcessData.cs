using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLTT
{
    public class ProcessData
    {
        /////////////////////////////////////////////////////////////////////////////
        //              Input Lag
        ////////////////////////////////////////////////////////////////////////////


        public class rawInputLagResult
        {
            public double ClickTime { get; set; }
            public float FrameTime { get; set; }
            public int TimeTaken { get; set; }
            public int SampleCount { get; set; }
            public double SampleTime { get; set; }
            public List<int> Samples { get; set; }
        }

        public class inputLagResult
        {
            public int shotNumber { get; set; }
            public double clickTimeMs { get; set; }
            public double frameTimeMs { get; set; }
            public double inputLag { get; set; }
            public double totalInputLag { get; set; }
            public double onDisplayLatency { get; set; }
        }

        public class averageInputLagResult
        {
            public double AVG { get; set; }
            public double MIN { get; set; }
            public double MAX { get; set; }
        }

        public class averagedInputLag
        {
            public List<inputLagResult> inputLagResults { get; set; }
            public averageInputLagResult ClickTime { get; set; }
            public averageInputLagResult FrameTime { get; set; }
            public averageInputLagResult onDisplayLatency { get; set; }
            public averageInputLagResult totalInputLag { get; set; }
        }

        public static List<inputLagResult> processInputLagData(List<rawInputLagResult> inputLagRawData)
        {
            List<inputLagResult> inputLagProcessed = new List<inputLagResult>();

            int shotNumber = 1;
            foreach (rawInputLagResult item in inputLagRawData)
            {
                try
                {


                    // Save start, end, time and sample count then clear the values from the array
                    double ClickTime = item.ClickTime;
                    float FrameTime = item.FrameTime;
                    int TimeTaken = item.TimeTaken;
                    int SampleCount = item.SampleCount;
                    int[] samples = item.Samples.ToArray();

                    double SampleTime = ((double)TimeTaken / (double)SampleCount); // Get the time taken between samples

                    // Clean up noisy data using moving average function
                    /*int period = 20;
                    int[] buffer = new int[period];
                    int[] averagedSamples = new int[samples.Length];
                    int current_index = 0;
                    for (int a = 0; a < samples.Length; a++)
                    {
                        buffer[current_index] = samples[a] / period;
                        int movAvg = 0;
                        for (int b = 0; b < period; b++)
                        {
                            movAvg += buffer[b];
                        }
                        averagedSamples[a] = movAvg;
                        current_index = (current_index + 1) % period;
                    }

                    samples = averagedSamples.Skip(period).ToArray(); //Moving average spoils the first 10 samples so currently removing them.
                    */
                    // removed smoothing to not spoil data/accuracy and it's just not needed.

                    // Initialise in-use variables
                    int transStart = 0;

                    int startMax = samples[5]; // Initialise these variables with a real value 
                    int startMin = samples[5]; // Initialise these variables with a real value 
                    int endMax = samples[samples.Length - 10]; // Initialise these variables with a real value 
                    int endMin = samples[samples.Length - 10]; // Initialise these variables with a real value 

                    // Build start min/max to compare against
                    for (int l = 0; l < 50; l++) //CHANGE TO 180 FOR RUN 2 DATA
                    {
                        if (samples[l] < startMin)
                        {
                            startMin = samples[l];
                        }
                        else if (samples[l] > startMax)
                        {
                            startMax = samples[l];
                        }
                    }



                    // Search for where the result starts transitioning - start is almost always less sensitive
                    for (int j = 0; j < samples.Length; j++)
                    {
                        if (samples[j] > (startMax))
                        {
                            if ((samples[j + 50] > (samples[j] + 50) || samples[j + 56] > (samples[j] + 50))
                                 && (samples[j + 100] > (samples[j] + 100) || samples[j + 106] > (samples[j] + 100))
                                 && (samples[j + 125] > (samples[j] + 100) || samples[j + 131] > (samples[j] + 100))
                                 && (samples[j + 150] > (samples[j] + 100) || samples[j + 156] > (samples[j] + 100))) // check the trigger point is actually the trigger and not noise
                            {
                                transStart = j;
                                break;
                            }
                            else
                            {
                                if (samples[j] > startMax)
                                {
                                    startMax = samples[j];
                                }
                            }
                        }
                    }

                    Console.WriteLine("ClickTime: " + ClickTime);
                    double clickTimeMs = ClickTime;
                    clickTimeMs /= 1000;
                    Console.WriteLine("ClickTimems: " + clickTimeMs);
                    double transTime = (transStart * SampleTime) / 1000;
                    double inputLag = Math.Round(transTime, 3);

                    double totalInputLag = (ClickTime + (transStart * SampleTime)) / 1000;
                    totalInputLag = Math.Round(totalInputLag, 3);

                    double onDisplayLag = inputLag - FrameTime;

                    if (clickTimeMs == totalInputLag || onDisplayLag < 0)
                    {
                        clickTimeMs = 0;
                        FrameTime = 0;
                        inputLag = 0;
                        totalInputLag = 0;
                        onDisplayLag = 0;
                    }

                    inputLagResult completeResult = new inputLagResult { shotNumber = shotNumber, clickTimeMs = clickTimeMs, frameTimeMs = Convert.ToDouble(FrameTime), inputLag = inputLag, totalInputLag = totalInputLag, onDisplayLatency = onDisplayLag };
                    inputLagProcessed.Add(completeResult);
                    shotNumber++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + ex.StackTrace);
                }
            }
            Console.WriteLine("Finished processing");
            return inputLagProcessed;
        }

        public static List<inputLagResult> processAudioLatencyData(List<rawInputLagResult> inputLagRawData)
        {
            List<inputLagResult> inputLagProcessed = new List<inputLagResult>();

            int shotNumber = 1;
            foreach (rawInputLagResult item in inputLagRawData)
            {
                // Save start, end, time and sample count then clear the values from the array
                double ClickTime = item.ClickTime;
                float FrameTime = item.FrameTime;
                int TimeTaken = item.TimeTaken;
                int SampleCount = item.SampleCount;
                int[] samples = item.Samples.ToArray();

                double SampleTime = ((double)TimeTaken / (double)SampleCount); // Get the time taken between samples

                // Clean up noisy data using moving average function
                /*int period = 20;
                int[] buffer = new int[period];
                int[] averagedSamples = new int[samples.Length];
                int current_index = 0;
                for (int a = 0; a < samples.Length; a++)
                {
                    buffer[current_index] = samples[a] / period;
                    int movAvg = 0;
                    for (int b = 0; b < period; b++)
                    {
                        movAvg += buffer[b];
                    }
                    averagedSamples[a] = movAvg;
                    current_index = (current_index + 1) % period;
                }

                samples = averagedSamples.Skip(period).ToArray(); //Moving average spoils the first 10 samples so currently removing them.
                */
                // removed smoothing to not spoil data/accuracy and it's just not needed.

                // Initialise in-use variables
                int transStart = 0;

                int startMax = samples[5]; // Initialise these variables with a real value 
                int startMin = samples[5]; // Initialise these variables with a real value 
                int endMax = samples[samples.Length - 10]; // Initialise these variables with a real value 
                int endMin = samples[samples.Length - 10]; // Initialise these variables with a real value 

                // Build start min/max to compare against
                for (int l = 0; l < 50; l++) //CHANGE TO 180 FOR RUN 2 DATA
                {
                    if (samples[l] < startMin)
                    {
                        startMin = samples[l];
                    }
                    else if (samples[l] > startMax)
                    {
                        startMax = samples[l];
                    }
                }



                // Search for where the result starts transitioning - start is almost always less sensitive
                for (int j = 0; j < samples.Length; j++)
                {
                    if (samples[j] > (startMax))
                    {
                        if ((samples[j + 50] > (samples[j] + 50) || samples[j + 56] > (samples[j] + 50))
                             && (samples[j + 100] > (samples[j] + 100) || samples[j + 106] > (samples[j] + 100))
                             && (samples[j + 125] > (samples[j] + 100) || samples[j + 131] > (samples[j] + 100))
                             && (samples[j + 150] > (samples[j] + 100) || samples[j + 156] > (samples[j] + 100))) // check the trigger point is actually the trigger and not noise
                        {
                            transStart = j;
                            break;
                        }
                        else
                        {
                            if (samples[j] > startMax)
                            {
                                startMax = samples[j];
                            }
                        }
                    }
                }

                Console.WriteLine("ClickTime: " + ClickTime);
                double clickTimeMs = ClickTime;
                clickTimeMs /= 1000;
                Console.WriteLine("ClickTimems: " + clickTimeMs);
                double transTime = (transStart * SampleTime) / 1000;
                double inputLag = Math.Round(transTime, 3);

                double totalInputLag = (ClickTime + (transStart * SampleTime)) / 1000;
                totalInputLag = Math.Round(totalInputLag, 3);

                double onDisplayLag = inputLag - FrameTime;

                if (clickTimeMs == totalInputLag || onDisplayLag < 0)
                {
                    clickTimeMs = 0;
                    FrameTime = 0;
                    inputLag = 0;
                    totalInputLag = 0;
                    onDisplayLag = 0;
                }

                inputLagResult completeResult = new inputLagResult { shotNumber = shotNumber, clickTimeMs = clickTimeMs, frameTimeMs = Convert.ToDouble(FrameTime), inputLag = inputLag, totalInputLag = totalInputLag, onDisplayLatency = onDisplayLag };
                inputLagProcessed.Add(completeResult);
                shotNumber++;
            }
            Console.WriteLine("Finished processing");
            return inputLagProcessed;
        }

        public static averagedInputLag AverageInputLagResults(List<rawInputLagResult> inputLagData, int type = 0)
        {
            averagedInputLag inputLagProcessed = new averagedInputLag();

            List<inputLagResult> processedResults;
            if (type == 0)
            {
                processedResults = processInputLagData(inputLagData);
            }
            else
            {
                processedResults = processAudioLatencyData(inputLagData);
            }
            if (processedResults.Count == 0)
            {
                throw new Exception("Processing Failed");
            }

            List<inputLagResult> clearedResults = inputLagOutlierRejection(processedResults);

            inputLagProcessed.inputLagResults = clearedResults;

            // convert to double array for each type of average
            inputLagProcessed.ClickTime = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            inputLagProcessed.FrameTime = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            inputLagProcessed.onDisplayLatency = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            inputLagProcessed.totalInputLag = new averageInputLagResult { AVG = 0, MIN = 100, MAX = 0 };
            for (int i = 0; i < inputLagProcessed.inputLagResults.Count; i++)
            {
                inputLagProcessed.ClickTime.AVG += inputLagProcessed.inputLagResults[i].clickTimeMs;
                inputLagProcessed.FrameTime.AVG += inputLagProcessed.inputLagResults[i].frameTimeMs;
                inputLagProcessed.onDisplayLatency.AVG += inputLagProcessed.inputLagResults[i].onDisplayLatency;
                inputLagProcessed.totalInputLag.AVG += inputLagProcessed.inputLagResults[i].totalInputLag;
                if (inputLagProcessed.inputLagResults[i].clickTimeMs < inputLagProcessed.ClickTime.MIN)
                {
                    inputLagProcessed.ClickTime.MIN = inputLagProcessed.inputLagResults[i].clickTimeMs;
                }
                else if (inputLagProcessed.inputLagResults[i].clickTimeMs > inputLagProcessed.ClickTime.MAX)
                {
                    inputLagProcessed.ClickTime.MAX = inputLagProcessed.inputLagResults[i].clickTimeMs;
                }
                if (inputLagProcessed.inputLagResults[i].frameTimeMs < inputLagProcessed.FrameTime.MIN)
                {
                    inputLagProcessed.FrameTime.MIN = inputLagProcessed.inputLagResults[i].frameTimeMs;
                }
                else if (inputLagProcessed.inputLagResults[i].frameTimeMs > inputLagProcessed.FrameTime.MAX)
                {
                    inputLagProcessed.FrameTime.MAX = inputLagProcessed.inputLagResults[i].frameTimeMs;
                }
                if (inputLagProcessed.inputLagResults[i].onDisplayLatency < inputLagProcessed.onDisplayLatency.MIN)
                {
                    inputLagProcessed.onDisplayLatency.MIN = inputLagProcessed.inputLagResults[i].onDisplayLatency;
                }
                else if (inputLagProcessed.inputLagResults[i].onDisplayLatency > inputLagProcessed.onDisplayLatency.MAX)
                {
                    inputLagProcessed.onDisplayLatency.MAX = inputLagProcessed.inputLagResults[i].onDisplayLatency;
                }
                if (inputLagProcessed.inputLagResults[i].totalInputLag < inputLagProcessed.totalInputLag.MIN)
                {
                    inputLagProcessed.totalInputLag.MIN = inputLagProcessed.inputLagResults[i].totalInputLag;
                }
                else if (inputLagProcessed.inputLagResults[i].totalInputLag > inputLagProcessed.totalInputLag.MAX)
                {
                    inputLagProcessed.totalInputLag.MAX = inputLagProcessed.inputLagResults[i].totalInputLag;
                }
            }
            inputLagProcessed.ClickTime.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.ClickTime.AVG = Math.Round(inputLagProcessed.ClickTime.AVG, 3);
            inputLagProcessed.FrameTime.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.FrameTime.AVG = Math.Round(inputLagProcessed.FrameTime.AVG, 3);
            inputLagProcessed.onDisplayLatency.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.onDisplayLatency.AVG = Math.Round(inputLagProcessed.onDisplayLatency.AVG, 3);
            inputLagProcessed.totalInputLag.AVG /= inputLagProcessed.inputLagResults.Count;
            inputLagProcessed.totalInputLag.AVG = Math.Round(inputLagProcessed.totalInputLag.AVG, 3);
            return inputLagProcessed;
        }

        public static List<inputLagResult> inputLagOutlierRejection(List<inputLagResult> res)
        {
            // Consider adding actual outlier rejection like response time averaging...
            List<inputLagResult> newRes = new List<inputLagResult>();
            newRes.AddRange(res);
            foreach (var i in res)
            {
                if (i.onDisplayLatency == 0)
                {
                    newRes.Remove(i);
                }
            }
            return newRes;
        }

    }

}
