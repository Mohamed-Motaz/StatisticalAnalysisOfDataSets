import matplotlib.pyplot as plt
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = dataSetImport.abbreviateStateNames(stateNames)
y = deathsPerState
z = percentageSmokersPerState

plt.scatter(x , y , label="States/Number Of Deaths" , color = "blue" , marker='o' )
plt.title("Scatter Plot")
plt.xlabel("States")
plt.ylabel("Number Of Deaths")
plt.legend()
plt.show()
