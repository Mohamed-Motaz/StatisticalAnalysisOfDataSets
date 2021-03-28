

import math

dummyData = [1,2,3,4,5,6,7,8,9,10]
dummyData2 = [1,2,3,4,5,6,7,8,9,10]
dummyDataFrequency = [1,2,3,4,5,6,7,8,9,10]

def calcMeanUnGroupedData(dataSet):
    """
    Calculate mean for grouped data
    """
    mean = 0
    for element in dataSet:
        mean += element
    mean = mean / len(dataSet)
    return float(mean)

print(calcMeanUnGroupedData(dummyData))    

def calcMeanGroupedData(dataSet, frequencySet):
    """
    Calculate mean for grouped data
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
    """
    Calculate variance for grouped data
    """
    mean = calcMeanGroupedData(dataSet, frequencySet)
    totalNum = 0
    sum = 0

    for i in range(0, len(dataSet)):
        sum += pow(dataSet[i] - mean, 2) * frequencySet[i]
        totalNum += frequencySet[i]
    
    return float(sum / (totalNum - 1))

def calcStandardDeviationGrouped(dataSet, frequencySet):
    """
    Calculate standard deviation for grouped data
    """
    return math.sqrt(calcVarianceGrouped(dataSet, frequencySet))

def calcVarianceUnGrouped(dataSet):
    """
    Calculate variance for ungrouped data 
    """
    mean = calcMeanUnGroupedData(dataSet)
    sum = 0

    for element in dataSet:
        sum += pow(element - mean, 2)

    return float(sum / (len(dataSet) - 1))


def calcStandardDeviationUnGrouped(dataSet):
    """
    Calculate standard deviation for ungrouped data
    """
    return math.sqrt(calcVarianceUnGrouped(dataSet))

def calcZScoreUnGrouped(idx, dataSet):
    """
    Calculate z-scroe for ungrouped data
    """
    return (dataSet[idx] - calcMeanUnGroupedData(dataSet) / calcStandardDeviationUnGrouped(dataSet))

def calcPearsonR(dataSet1, dataSet2):
    """
    Calculate Pearson's R for two datasets
    """
    sum = 0

    for i in range(0, len(dataSet1)):
        sum += calcZScoreUnGrouped(i, dataSet1) * calcZScoreUnGrouped(i, dataSet2)

    return float(sum / (len(dataSet1) - 1))

def calcCoefficientOfDetermination(dataSet1, dataSet2):
    """
    Calculate coefficient of determination for two datasets
    """
    return float(pow(calcPearsonR(dataSet1, dataSet2), 2))

def calcBOne(dataSet1, dataSet2):
    """
    Calculate b1 for two datasets
    """
    r = calcPearsonR(dataSet1, dataSet2)
    sX = calcStandardDeviationUnGrouped(dataSet1)
    sY = calcStandardDeviationUnGrouped(dataSet2)

    return float( (sY / sX)  * r )


def calcBNode(dataSet1, dataSet2):
    """
    Calculate b0 for two datasets
    """
    yMean = calcMeanUnGroupedData(dataSet2)
    xMean = calcMeanUnGroupedData(dataSet1)
    bOne = calcBOne(dataSet1, dataSet2)

    return float(yMean - bOne * xMean) 


def calcPredictedY(dataSet1, dataSet2, x):
    """
    Calculate predicted y for two datasets given x
    """
    bOne = calcBOne(dataSet1, dataSet2)
    bNode = calcBNode(dataSet1, dataSet2)

    return float(bOne * x + bNode)

def calcNumberOfClassesForHistogram(dataSet):
    return int(math.ceil(math.sqrt(len(dataSet))))


