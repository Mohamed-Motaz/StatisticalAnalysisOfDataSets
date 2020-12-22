import matplotlib.pyplot as plt 
import numpy as np 
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = dataSetImport.abbreviateStateNames(stateNames)
y = percentageDeathsPerState
z = percentageSmokersPerState

    
# Creating dataset 
np.random.seed(10)

data =  z
  
tmp,ax1=plt.subplots()

red_square = dict(markerfacecolor='r', marker='s')

ax1.boxplot(data, flierprops=red_square,meanline=True,showfliers=True)

ax1.set_title('Box Plot')
#patch.set_facecolor("pink")
ax1.set_ylabel('Percentage of Smokers')

# Creating plot 
ax1.boxplot(data) 
  
# show plot 
plt.show()