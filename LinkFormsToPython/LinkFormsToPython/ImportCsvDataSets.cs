﻿using System;
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
        public static List<String> stateNames = new List<string>();
        public static List<double> deathsPerState = new List<double>();
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
                }
            }
        
        }
            
        private static void fillListsFromDictionaries()
        {
            foreach (KeyValuePair<string,int> entry in stateAndDeathsDictionary){
                stateNames.Add(entry.Key);
                deathsPerState.Add(entry.Value);
                percentageSmokersPerState.Add(stateAndSmokingDictionary[entry.Key]);
            }
                
        }
            

        //priv abbreviateStateNames(statesNames):
        //    newStatesNames = []
        //    for i in range(0, len(stateNames)):
        //        newStatesNames.append(stateNames[i][0] + stateNames[i][1])
        //    return newStatesNames

        //def turnPercentageFromFloatToInt(percentageSmokersPerState):
        //    newPercentageSmokersPerState = []
        //    for i in range(0, len(percentageSmokersPerState)):
        //        newPercentageSmokersPerState.append(int(percentageSmokersPerState[i]))
        //    return newPercentageSmokersPerState

        public static void run()
        {
            fillDictionariesFromCSV();
            fillListsFromDictionaries();
            
        }

    }
}





