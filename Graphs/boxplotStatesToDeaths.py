import matplotlib.pyplot as plt 
import numpy as np 
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = dataSetImport.abbreviateStateNames(stateNames)
y = deathsPerState
z = percentageSmokersPerState

    
# Creating dataset 
np.random.seed(10)

data =  y
  
tmp,ax1=plt.subplots()

red_square = dict(markerfacecolor='r', marker='s')

ax1.boxplot(data, flierprops=red_square,meanline=True,showfliers=True)

ax1.set_title('Box Plot')
#patch.set_facecolor("pink")
ax1.set_ylabel('Number of Deaths')
 
# Creating plot 
ax1.boxplot(data) 
  
# show plot 
plt.show()