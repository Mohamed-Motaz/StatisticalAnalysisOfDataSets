import matplotlib.pyplot as plt
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = deathsPerState
z = percentageSmokersPerState

plt.scatter(x , y , label="weights/Chocolate" , color = "blue" , marker='o' )
plt.title("Scatter Plot")
plt.xlabel("x-axis")
plt.ylabel("y-axis")
plt.legend()
plt.show()

plt.scatter(x , z , label="weights/Chocolate" , color = "blue" , marker='o' )
plt.title("Scatter Plot")
plt.xlabel("x-axis")
plt.ylabel("y-axis")
plt.legend()
plt.show()