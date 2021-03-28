import matplotlib.pyplot as plt
import numpy as np
from sklearn.linear_model import LinearRegression
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = percentageSmokersPerState

X = np.array(z).reshape(-1, 1)  # [1,2,3,4] => [[1],[2],[3],[4]]
Y = np.array(y)
li_rg = LinearRegression()
li_rg.fit(X, Y)
Y_pred = li_rg.predict(X)
predictedX = [[25], [26], [27], [28], [29], [30]]
predictedY = li_rg.predict(predictedX)


plt.plot(X, Y_pred, color="blue", label="Regression line")
plt.scatter(predictedX, predictedY, color="orange", label="Data Prediction")
plt.scatter(X, Y, color="green", label="Points")

plt.xlabel("Percentage of Smokers")
plt.ylabel("Percentage of Deaths")
plt.legend()
plt.show()

