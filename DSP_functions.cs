using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sPlotter
{
    public static class DSP_functions
    {
        public static List<double> MovingAverage(List<double> data, int windowSize)
        {
            List<double> filteredData = new List<double>();

            for (int i = windowSize - 1; i != (data.Count - 1); i++)
            {
                double sum = 0;

                for (int j = windowSize - 1; j != 0; j--)
                {
                    sum = sum + data[i - j];

                }

                // Calculate the average and add it to the filtered data
                filteredData.Add((double)(sum / windowSize));
            }

            return filteredData;
        }

        public static List<double> Median_Filter(List<double> data, int windowSize)
        {
            List<double> filteredData = new List<double>();

            for (int i = 0; i <= data.Count - windowSize; i++)
            {
                List<double> temp = new List<double>();

                // Populate the temporary list with data within the window
                for (int j = i; j < i + windowSize; j++)
                {
                    temp.Add(data[j]);
                }

                // Sort the temporary list
                temp.Sort();

                double median;
                int mid = windowSize / 2;

                // Calculate median based on window size
                if (windowSize % 2 == 0)
                {
                    median = (temp[mid - 1] + temp[mid]) / 2.0;
                } else
                {
                    median = temp[mid];
                }

                // Add median to the filtered data
                filteredData.Add(median);
            }

            return filteredData;
        }



        public static double[] Lowpass(List<double> x, double dt, double RC)
        {
            int n = x.Count;
            double[] y = new double[n];
            double alpha = dt / (RC + dt);

            y[0] = alpha * x[0];

            for (int i = 1; i < n; i++)
            {
                y[i] = alpha * x[i] + (1 - alpha) * y[i - 1];
            }
            return y;
        }

        public static double[] Highpass(List<double> x, double dt, double RC)
        {
            int n = x.Count;
            double[] y = new double[n];
            double alpha = RC / (RC + dt);

            y[0] = x[0];
            for (int i = 1; i < n; i++)
            {
                y[i] = alpha * y[i - 1] + alpha * (x[i] - x[i - 1]);
            }

            return y;
        }

        public static List<double> WienerFilter(List<double> data, int windowSize)
        {

            List<double> filteredData = new List<double>();


            for (int i = 0; i <= data.Count - windowSize; i++)
            {

                List<double> window = new List<double>();
                for (int j = i; j < i + windowSize; j++)
                {
                    window.Add(data[j]);
                }


                double mean = window.Average();
                double variance = window.Sum(val => (val - mean) * (val - mean)) / windowSize;


                double signalVariance = variance > 0 ? variance : 0.0001;
                double filteredVal = mean + (signalVariance / (signalVariance + variance)) * (data[i] - mean);


                filteredData.Add(filteredVal);
            }

            return filteredData;
        }

    }
}
