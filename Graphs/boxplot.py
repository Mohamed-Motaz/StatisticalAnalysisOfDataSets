import matplotlib.pyplot as plt 
import numpy as np 
    
# Creating dataset 
np.random.seed(10)

data =  [0,5.6,8.7,14.1,14.1,15,17.2,19.2,19.3,24.1,27.7]
  
Bedoazim,ax1=plt.subplots()

red_square = dict(markerfacecolor='r', marker='s')

ax1.boxplot(data, flierprops=red_square,meanline=True,showfliers=True)

ax1.set_title('BoxPlot')
#patch.set_facecolor("pink")
  
# Creating plot 
ax1.boxplot(data) 
  
# show plot 
plt.show()