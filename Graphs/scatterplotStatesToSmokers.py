import matplotlib.pyplot as plt
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = dataSetImport.abbreviateStateNames(stateNames)
y = deathsPerState
z = percentageSmokersPerState


plt.scatter(x , z , label="States/Percentage of Smokers" , color = "blue" , marker='o' )
plt.title("Scatter Plot")
plt.xlabel("States")
plt.ylabel("Percentage of Smokers")
plt.legend()
plt.show()