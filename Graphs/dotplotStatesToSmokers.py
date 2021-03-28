#rawan
import matplotlib.pyplot as plt
import numpy as np
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = dataSetImport.turnPercentageFromFloatToInt(percentageSmokersPerState)

dictt={}

xvalues = z

zvalues=[]
for i in xvalues:
    if i in dictt:
        dictt[i]+=1
    else:
         dictt[i]=1
    zvalues.append(dictt[i])


plt.plot(xvalues, zvalues, 'go', markersize=8)

plt.xlabel('Percentage of Smokers')
plt.ylabel('Frequency')

plt.title('Dot plot graph')
plt.show()