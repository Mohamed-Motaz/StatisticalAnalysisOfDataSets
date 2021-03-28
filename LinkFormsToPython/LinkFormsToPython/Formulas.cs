using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkFormsToPython
{
    class Formulas
    {
        List<double> dummyData = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        List<double> dummyData2 = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<double> dummyDataFrequency = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static double calcMeanUnGroupedData(List<double> dataSet)
        {
            /*
            Calculate mean for grouped data
            */
            double mean = 0;
            foreach (int element in dataSet)
            {
                mean += element;
            }

            mean /= (double)(dataSet.Count);

            return mean;
        }

        public static double calcMeanGroupedData(List<double> dataSet, List<double> frequencySet)
        {
            /*
            Calculate mean for grouped data
            */
            if (dataSet.Count != frequencySet.Count)
                throw new Exception("Data set and frequency set sizes not equal");
            

            double mean = 0;
            double numberOfElements = 0;
            for (int i = 0; i < dataSet.Count; i++) {

                mean += dataSet[i] * frequencySet[i];
                numberOfElements += frequencySet[i];
            }
            mean /= numberOfElements;
            return mean;
        }

        public static double calcVarianceGrouped(List<double> dataSet, List<double> frequencySet)
        {
            /*
            Calculate variance for grouped data
            */
            double mean = calcMeanGroupedData(dataSet, frequencySet);
            double sum = 0;
            double totalNum = 0;
            for (int i = 0; i < dataSet.Count; i++)
            {
                sum += Math.Pow(dataSet[i] - mean, 2) * frequencySet[i];
                totalNum += frequencySet[i];
            }
               


            return sum / (totalNum - 1);
        }
    

        public static double calcStandardDeviationGrouped(List<double> dataSet, List<double> frequencySet)
        {
            /*
            Calculate standard deviation for grouped data
            */
            return Math.Sqrt(calcVarianceGrouped(dataSet, frequencySet));
        }
    

        public static double calcVarianceUnGrouped(List<double> dataSet)
        {
            /*
            Calculate variance for ungrouped data 
            */
            double mean = calcMeanUnGroupedData(dataSet);
            double sum = 0;

            foreach (double element in dataSet)
                sum += Math.Pow(element - mean, 2);

            return (sum / (dataSet.Count - 1));
        }
            


        public static double calcStandardDeviationUnGrouped(List<double> dataSet)
        {
            /*
            Calculate standard deviation for ungrouped data
            */
            return Math.Sqrt(calcVarianceUnGrouped(dataSet));
        }
            

        public static double calcZScoreUnGrouped(int idx, List<double> dataSet)
        {
            /*
            Calculate z-scroe for ungrouped data
            */
            return (dataSet[idx] - calcMeanUnGroupedData(dataSet)) / calcStandardDeviationUnGrouped(dataSet);
        }
           

        public static double calcPearsonR(List<double> dataSet1, List<double> dataSet2)
        {
            /*
            Calculate Pearson's R for two datasets
            */
            double sum = 0;

            for (int i = 0; i < dataSet1.Count; i++)
                sum += calcZScoreUnGrouped(i, dataSet1) * calcZScoreUnGrouped(i, dataSet2);

            return (sum / (dataSet1.Count - 1));
        }
            

        public static double calcCoefficientOfDetermination(List<double> dataSet1, List<double> dataSet2)
        {
            /*
            Calculate coefficient of determination for two datasets
            */
            return Math.Pow(calcPearsonR(dataSet1, dataSet2), 2);
        }
            

        public static double calcBOne(List<double> dataSet1, List<double> dataSet2)
        {
            /*
            Calculate b1 for two datasets
            */
            double r = calcPearsonR(dataSet1, dataSet2);
            double sX = calcStandardDeviationUnGrouped(dataSet1);
            double sY = calcStandardDeviationUnGrouped(dataSet2);

            return (sY / sX) * r;
        }
            


        public static double calcBNode(List<double> dataSet1, List<double> dataSet2)
        {
            /*
            Calculate b0 for two datasets
            */
            double yMean = calcMeanUnGroupedData(dataSet2);
            double xMean = calcMeanUnGroupedData(dataSet1);
            double bOne = calcBOne(dataSet1, dataSet2); 

            return (yMean - bOne * xMean); 
        }
            


        public static double calcPredictedY(List<double> dataSet1, List<double> dataSet2, double x)
        {
            /*
            Calculate predicted y for two datasets given x
            */
            double bOne = calcBOne(dataSet1, dataSet2);
            double bNode = calcBNode(dataSet1, dataSet2);

            return (bOne * x + bNode);
        }
            

        

        public static double calcMedian(List<double> dataSet)
        {
            dataSet.Sort();
            double median;
            int mid = dataSet.Count / 2;
            if (dataSet.Count % 2 == 0)
                median = (dataSet[mid] + dataSet[mid - 1]) / 2.0;

            else
                median = dataSet[mid];

            return median;
        }

        public static double calcMode(List<double> dataSet)
        {
            Dictionary<double, int> dict = new Dictionary<double, int>();
            //round all values to 2 decimal points
            for (int i = 0; i < dataSet.Count; i++)
            {
                if (dict.ContainsKey(Math.Round(dataSet[i], 2)))
                    dict[Math.Round(dataSet[i], 2)]++;
                else dict[Math.Round(dataSet[i], 2)] = 1;
            }

            int mxCtr = 0;
            double val = 0.0;

            foreach( KeyValuePair<double, int> pair in dict)
            {
                if (pair.Value > mxCtr)
                {
                    val = pair.Key;
                    mxCtr = pair.Value;
                }
            }
            return val;
        }
            
    }
}   
