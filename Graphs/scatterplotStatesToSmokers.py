import matplotlib.pyplot as plt
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = percentageSmokersPerState


plt.scatter(x , z , label="States/Percentage of Smokers" , color = "blue" , marker='o' )
plt.title("Scatter Plot")
plt.xlabel("States")
plt.ylabel("Percentage of Smokers")
plt.legend()
plt.show()