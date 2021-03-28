import matplotlib.pyplot as plt 
import numpy as np 
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = percentageSmokersPerState

    


data =  y
  
tmp,ax1=plt.subplots()

blue_square = dict(markerfacecolor='b', marker='s')

ax1.boxplot(data, flierprops=blue_square,showfliers=True)

ax1.set_title('Box Plot')
ax1.set_ylabel('Percentage of Deaths')
 
  
plt.show()