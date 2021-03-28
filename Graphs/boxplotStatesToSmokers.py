import matplotlib.pyplot as plt 
import numpy as np 
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = percentageSmokersPerState

    

data =  z
  
tmp,ax1=plt.subplots()

red_square = dict(markerfacecolor='r', marker='s')

ax1.boxplot(data, flierprops=red_square,showfliers=True)

ax1.set_title('Box Plot')
ax1.set_ylabel('Percentage of Smokers')


  
plt.show()