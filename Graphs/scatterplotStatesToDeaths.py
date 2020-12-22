import matplotlib.pyplot as plt
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = dataSetImport.abbreviateStateNames(stateNames)
y = percentageDeathsPerState
z = percentageSmokersPerState

plt.scatter(x , y , label="States/Percentage Of Deaths" , color = "blue" , marker='o' )
plt.title("Scatter Plot")
plt.xlabel("States")
plt.ylabel("Percentage Of Deaths")
plt.legend()
plt.show()
