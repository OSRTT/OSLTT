﻿using System;
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
            public resultType ResultType { get; set; }
            public double ClickTime { get; set; }
            public float FrameTime { get; set; }
            public int TimeTaken { get; set; }
            public int SampleCount { get; set; }
            public double SampleTime { get; set; }
            public List<int> Samples { get; set; }
        }

        public enum resultType
        {
            Light,
            Click,
            Audio
        }

        public class inputLagResult
        {
            public resultType Type { get; set; }
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
            public string RunName { get; set; }
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
                    int period = 10;
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
                    /*foreach (var i in samples)
                    {
                        Console.Write(i + ",");
                    }
                    Console.WriteLine();*/

                    // Initialise in-use variables
                    int transStart = 0;

                    int startMax = samples[5]; // Initialise these variables with a real value 
                    int startMin = samples[5]; // Initialise these variables with a real value 
                    int endMax = samples[samples.Length - 10]; // Initialise these variables with a real value 
                    int endMin = samples[samples.Length - 10]; // Initialise these variables with a real value 

                    // Build start min/max to compare against
                    int minMaxCount = 50;  // 50 samples at 15.27us = 763us. Under 1ms. More = more stable, but longer minimum time
                    for (int l = 0; l < minMaxCount; l++)
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
                    for (int l = samples.Length - 1; l > samples.Length - minMaxCount; l--) 
                    {
                        if (samples[l] < endMin)
                        {
                            endMin = samples[l];
                        }
                        else if (samples[l] > endMax)
                        {
                            endMax = samples[l];
                        }
                    }
                                        
                    //Check if the data contains a pulse that's 20% greater than BOTH the start and end maximums
                    if (samples.Max() > (startMax * 1.2) && samples.Max() > (endMax * 1.2))
                    {
                        Console.WriteLine("Pulse Detected");
                        // Search for where the result starts transitioning - start is almost always less sensitive
                        for (int j = 0; j < samples.Length; j++)
                        {
                            if (samples[j] > (startMax * 1.2))
                            {
                                if ((samples[j + 50] > (samples[j] * 1.5) || samples[j + 56] > (samples[j] *1.5))
                                     && (samples[j + 100] > (samples[j] *1.5) || samples[j + 106] > (samples[j] *1.5))
                                     && (samples[j + 125] > (samples[j] *2) || samples[j + 131] > (samples[j] *2))
                                     && (samples[j + 150] > (samples[j] *2) || samples[j + 156] > (samples[j] *2))) 
                                {
                                    transStart = j;
                                    break;
                                }
                                else if ((samples[j + 250] > (samples[j] * 1.5) || samples[j + 256] > (samples[j] * 1.5))
                                     && (samples[j + 300] > (samples[j] * 1.5) || samples[j + 306] > (samples[j] * 1.5))
                                     && (samples[j + 325] > (samples[j] * 1.75) || samples[j + 331] > (samples[j] * 1.75))
                                     && (samples[j + 350] > (samples[j] * 2) || samples[j + 356] > (samples[j] * 2))) // catch for slow transitions
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
                    }
                    //Rising transition
                    else if (startMax < endMax || item.ResultType == resultType.Audio)
                    {
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
                    }
                    else // falling transition
                    {
                        for (int j = 0; j < samples.Length; j++)
                        {
                            if (samples[j] < (startMin))
                            {
                                if ((samples[j + 50] < (samples[j] - 50) || samples[j + 56] < (samples[j] - 50))
                                        && (samples[j + 100] < (samples[j] - 100) || samples[j + 106] < (samples[j] - 100))
                                        && (samples[j + 125] < (samples[j] - 100) || samples[j + 131] < (samples[j] - 100))
                                        && (samples[j + 150] < (samples[j] - 100) || samples[j + 156] < (samples[j] - 100))) // check the trigger point is actually the trigger and not noise
                                {
                                    transStart = j;
                                    break;
                                }
                                else
                                {
                                    if (samples[j] < startMin)
                                    {
                                        startMin = samples[j];
                                    }
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

                    inputLagResult completeResult = new inputLagResult { Type=resultType.Light, shotNumber = shotNumber, clickTimeMs = clickTimeMs, frameTimeMs = Convert.ToDouble(FrameTime), inputLag = inputLag, totalInputLag = totalInputLag, onDisplayLatency = onDisplayLag };
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
                for (int l = 0; l < 300; l++) //CHANGE TO 180 FOR RUN 2 DATA
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
                for (int j = 0; j < samples.Length - 17; j++)
                {
                    if (samples[j] > (startMax))
                    {

                        if ((samples[j + 10] > (samples[j] + 2000) || samples[j + 16] > (samples[j] + 2000))
                            || (samples[j + 2] > (samples[j] - 2000) || samples[j + 12] > (samples[j] - 2000)))
                        {
                            if (samples[j] > startMax + 2000)
                            {
                                transStart = j;
                            }

                            //break;
                        }
                        else if (samples[j] > 16000) // backup in case spike is only a couple samples. Shouldn't really be needed
                        {
                            int countPeakResults = 0;
                            for (int p = j; p < j + 50; p++)
                            {
                                if (samples[p] > 16000)
                                {
                                    countPeakResults++;
                                }
                            }
                            if (countPeakResults > 2) // tweak this for reliable clicks at different volumes
                            {
                                transStart = j;

                            }
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

                inputLagResult completeResult = new inputLagResult { Type=resultType.Audio, shotNumber = shotNumber, clickTimeMs = clickTimeMs, frameTimeMs = Convert.ToDouble(FrameTime), inputLag = inputLag, totalInputLag = totalInputLag, onDisplayLatency = onDisplayLag };
                inputLagProcessed.Add(completeResult);
                shotNumber++;
            }
            Console.WriteLine("Finished processing");
            return inputLagProcessed;
        }

        public static averagedInputLag AverageInputLagResults(List<rawInputLagResult> inputLagData)
        {
            averagedInputLag inputLagProcessed = new averagedInputLag();

            if (inputLagData.Count == 0)
            {
                throw new Exception("No results provided");
            }

            List<inputLagResult> processedResults;
            if (inputLagData[0].ResultType == resultType.Light)
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

            return averageResults(inputLagProcessed);
        }

        public static averagedInputLag AveragePreProecessedResults(List<inputLagResult> res)
        {
            // This is the function to process clicks type measurements 
            averagedInputLag inputLag = new averagedInputLag();

            List<inputLagResult> processedResults = inputLagOutlierRejection(res, true);
            inputLag.inputLagResults = processedResults;
            return averageResults(inputLag);
        }

        public static double GetMedian(double[] sourceNumbers)
        {
            //Framework 2.0 version of this method. there is an easier way in F4        
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new System.Exception("Median of empty array not defined.");

            //make sure the list is sorted, but use a new array
            double[] sortedPNumbers = (double[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);

            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        public static List<inputLagResult> inputLagOutlierRejection(List<inputLagResult> res, bool removeOutliers = false)
        {
            // Consider adding actual outlier rejection like response time averaging...
            List<double> resultsList = new List<double>();

            List<inputLagResult> newRes = new List<inputLagResult>();
            newRes.AddRange(res);
            
                foreach (var i in res)
                {
                    if (i.onDisplayLatency == 0 && res[0].Type == resultType.Light)
                    {
                        newRes.Remove(i);
                    }
                    resultsList.Add(i.totalInputLag);
                }

            List<inputLagResult> newRes2 = new List<inputLagResult>();
            newRes2.AddRange(newRes);
            // find median of results
            double median = GetMedian(resultsList.ToArray());
            if (removeOutliers)
            {
                foreach (var i in newRes)
                {
                    if (i.totalInputLag > (median * 3) || i.totalInputLag < (median / 3))
                    {
                        newRes2.Remove(i);
                    }
                    else if (i.totalInputLag == 0)
                    {
                        newRes2.Remove(i);
                    }
                }
            }

            return newRes2;
        }

        public static averagedInputLag averageResults(averagedInputLag input)
        {
            averagedInputLag inputLagProcessed = input;
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

    }

}
