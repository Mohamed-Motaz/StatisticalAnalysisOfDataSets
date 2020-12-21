#rawan
import matplotlib.pyplot as plt
import numpy as np
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = dataSetImport.roundDeathsToTheNearestThousand(deathsPerState)
z = percentageSmokersPerState

dict={}


xvalues = y
#yvalues=[1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3]
zvalues=[]
for i in xvalues:
    if i in dict:
        dict[i]+=1
    else:
         dict[i]=1
    zvalues.append(dict[i])
#for i in zvalues:
    #print(i)
plt.plot(xvalues, zvalues, 'go', markersize=8)

# axis labeling
plt.xlabel('Deaths Per State')
plt.ylabel('Frequency')

# figure name
plt.title('Dot plot graph')
plt.show()