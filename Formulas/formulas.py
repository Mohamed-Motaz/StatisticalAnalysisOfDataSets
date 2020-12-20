import math

dummyData = [1,2,3,4,5,6,7,8,9,10]
dummyDataFrequency = [1,2,3,4,5,6,7,8,9,10]

def calcMeanUnGroupedData(dataSet):
    """
    Calculate mean for grouped data using the value
    """
    mean = 0
    for element in dataSet:
        mean += element
    mean = mean / len(dataSet)
    return float(mean)

print(calcMeanUnGroupedData(dummyData))    

def calcMeanGroupedData(dataSet, frequencySet):
    """
    Calculate mean for grouped data using the value
    """
    if len(dataSet) != len(frequencySet):
        raise Exception("Data set and frequency set sizes not equal")
        
    mean = 0
    numberOfElements = 0    
    for i in range(0, len(dataSet)):
        mean += dataSet[i] * frequencySet[i]
        numberOfElements += frequencySet[i]

    mean = mean / numberOfElements
    return float(mean)

print(calcMeanGroupedData(dummyData, dummyDataFrequency))


def calcVarianceGrouped(dataSet, frequencySet):
    mean = calcMeanGroupedData(dataSet, frequencySet)
    sum = 0

    for i in range(0, len(dataSet)):
        sum += pow(dataSet[i] - mean, 2) * frequencySet[i]
    
    return float(sum / (len(dataSet) - 1))

def calcStandardDeviationGrouped(dataSet, frequencySet):
    return sqrt(calcVarianceGrouped(dataSet, frequencySet))

def calcVarianceUnGrouped(dataSet):
    mean = calcMeanUnGroupedData(dataSet)
    sum = 0

    for element in dataSet:
        sum += pow(element - mean, 2)

    return float(sum / (len(dataSet) - 1))


def calcStandardDeviationUnGrouped(dataSet):
    return sqrt(calcVarianceUnGrouped(dataSet))

def calcZScoreUnGrouped(idx, dataSet):
    return (dataSet[idx] - calcMeanUnGroupedData(dataSet) / calcStandardDeviationUnGrouped(dataSet))


#b1 b0

