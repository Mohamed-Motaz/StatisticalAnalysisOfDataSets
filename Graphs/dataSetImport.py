import csv
import math

dataSetPath = r"C:\Users\moham\Desktop\imputed-data.csv"
#####################################
#Column names are date, county_fips, county_name, state_fips, state_name, 
#covid_19_confirmed_cases, covid_19_deaths, social_distancing_total_grade, 
#social_distancing_encounters_grade, social_distancing_travel_distance_grade, 
#daily_state_test, precipitation, temperature, virus_pressure, 
#total_population, population_ratio_in_state, female_percent, area, 
#population_density, latitude, longitude, hospital_beds_ratio, 
#ventilator_capacity_ratio, icu_beds_ratio, houses_density, 
#less_than_high_school_diploma, high_school_diploma_only, 
# some_college_or_higher, total_college_population, percent_smokers,
# percent_diabetes, Religious_congregation_ratio, political_party, 
# airport_distance, passenger_load_ratio, meat_plants, 
# median_household_income, percent_insured, deaths_per_100000, 
#gdp_per_capita, age_0_4, age_5_9, age_10_14, age_15_19, age_20_24, 
#age_25_29, age_30_34, age_35_39, age_40_44, age_45_49, age_50_54,
#age_55_59, age_60_64, age_65_69, age_70_74, age_75_79, age_80_84, 
# age_85_or_higher, immigrant_student_ratio, 
# retail_and_recreation_mobility_percent_change, 
# grocery_and_pharmacy_mobility_percent_change, 
# workplaces_mobility_percent_change
#######################################

stateAndDeathsDictionary = dict()
stateAndSmokingDictionary = dict()
stateNames = []
deathsPerState = []
percentageSmokersPerState = []


def getIdxes(row):
    """
    Get idxes for all three elements from 
    a list containing the headers of all
    columns in the csv file
    """
    for i in range(0, len(row)):
        if row[i] == 'state_name':
            idxState = i
        if row[i] == 'covid_19_deaths':
            idxDeaths = i
        if row[i] == 'percent_smokers':
            idxSmoking = i
    
    return idxState, idxDeaths, idxSmoking



def fillDictionariesFromCSV():
    """
    Fill two dictionaries linking state and deaths
    and state and percentage population that smokes
    """
    with open(dataSetPath, mode = 'r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter = ',')
        line_count = 0
    
        for row in csv_reader:
            
            if line_count == 0:
                #dont add column names to the dictionary
                idxState, idxDeaths, idxSmoking = getIdxes(row)
                line_count += 1
                continue
            if  row[idxState] in stateAndDeathsDictionary:
                stateAndDeathsDictionary[row[idxState]] += int((float(row[idxDeaths])))
            else:
                stateAndDeathsDictionary[row[idxState]] = int((float(row[idxDeaths])))
            stateAndSmokingDictionary[row[idxState]] = float(row[idxSmoking])
            #print(f'Column names are {", ".join(row)}')
        
stateNames = []
deathsPerState = []
percentageSmokersPerState = []
def fillListsFromDictionaries():
    counter = 0
    for key, value in stateAndDeathsDictionary.items():
        stateNames.append(key)
        deathsPerState.append(value)
        percentageSmokersPerState.append(stateAndSmokingDictionary[key])
    return
    
def abbreviateStateNames(statesNames):
    newStatesNames = []
    for i in range(0, len(stateNames)):
        newStatesNames.append(stateNames[i][0] + stateNames[i][1])
    return newStatesNames

def turnPercentageFromFloatToInt(percentageSmokersPerState):
    newPercentageSmokersPerState = []
    for i in range(0, len(percentageSmokersPerState)):
        newPercentageSmokersPerState.append(int(percentageSmokersPerState[i]))
    return newPercentageSmokersPerState

def run():
    fillDictionariesFromCSV()
    fillListsFromDictionaries()
    return stateNames, deathsPerState, percentageSmokersPerState





#for i in range(0, len(stateNames)):
#    print(stateNames[i], deathsPerState[i], percentageSmokersPerState[i])  

