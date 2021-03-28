using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LinkFormsToPython
{
    class ImportCsvDataSets
    {

        public static Dictionary<string, int> stateAndDeathsDictionary = new Dictionary<string, int>();
        public static Dictionary<string, double> stateAndSmokingDictionary = new Dictionary<string, double>();
        public static Dictionary<string, double> stateAndCovidPosDictionary = new Dictionary<string, double>();
        public static List<String> stateNames = new List<string>();
        public static List<double> percentageDeathsPerState = new List<double>();
        public static List<double> percentageSmokersPerState = new List<double>();

        private static string dataSetPath = @"C:\Users\moham\Desktop\imputed-data.csv";

        private static Dictionary<string, int> getIdxes(List<string> row)
        {
            /*
            Get idxes for all three elements from
            a list containing the headers of all
            columns in the csv file
            */

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < row.Count; i++)
            {
                if (row[i] == "state_name")
                    dict["idxState"] = i;
                if (row[i] == "covid_19_deaths")
                    dict["idxDeaths"] = i;
                if (row[i] == "percent_smokers")
                    dict["idxSmoking"] = i;
                if (row[i] == "total_population")
                    dict["idxCovidPositive"] = i;
            }
            return dict;
        }

        private static void fillDictionariesFromCSV()
        {
            /*
            Fill two dictionaries linking state and deaths
            and state and percentage population that smokes
            */
            Dictionary<string, int> getIdxs = new Dictionary<string, int>();
            int lineCount = 0;
            using (var reader = new StreamReader(dataSetPath))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var row = line.Split(',').ToList();
                    if (lineCount == 0)
                    {
                        getIdxs = getIdxes(row);
                        lineCount++;
                        continue;
                    }
                    
                    if (stateAndDeathsDictionary.ContainsKey(row[getIdxs["idxState"]]))
                        stateAndDeathsDictionary[row[getIdxs["idxState"]]] += Convert.ToInt32((double.Parse(row[getIdxs["idxDeaths"]])));
                    else
                        stateAndDeathsDictionary[row[getIdxs["idxState"]]] = Convert.ToInt32((double.Parse(row[getIdxs["idxDeaths"]])));
                    stateAndSmokingDictionary[row[getIdxs["idxState"]]] = double.Parse(row[getIdxs["idxSmoking"]]);
                    stateAndCovidPosDictionary[row[getIdxs["idxState"]]] = double.Parse(row[getIdxs["idxCovidPositive"]]);
                }
            }
        
        }
            
        private static void fillListsFromDictionaries()
        {
            foreach (KeyValuePair<string,int> entry in stateAndDeathsDictionary){
                stateNames.Add(entry.Key);
                percentageDeathsPerState.Add((double)entry.Value / (double)stateAndCovidPosDictionary[entry.Key]);
                percentageSmokersPerState.Add(stateAndSmokingDictionary[entry.Key]);
            }

            //percentageDeathsPerState = new List<double>() { 38, 41, 45, 48, 51, 53, 57, 61, 65 };
            //percentageSmokersPerState = new List<double>() { 116, 120, 123, 131, 142, 145, 148, 150, 152 };


        }
            


        public static void run()
        {
            fillDictionariesFromCSV();
            fillListsFromDictionaries();
            
        }

    }
}






