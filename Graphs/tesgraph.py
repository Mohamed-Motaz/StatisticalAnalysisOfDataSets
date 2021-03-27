import matplotlib.pyplot as plt
import numpy as np
from sklearn.linear_model import LinearRegression
# plt.plot([1, 2, 3, 4])
# plt.ylabel('some numbers')
# plt.show()
df =  [38, 41, 45, 48, 51, 53, 57, 61, 65]
dx = [116, 120, 123, 131, 142, 145, 148, 150, 152]
X = np.array(df).reshape(-1, 1)
Y = np.array(dx)
linear_regressor = LinearRegression()
linear_regressor.fit(X, Y)
Y_pred = linear_regressor.predict(X)
# Scatter Graph(With Regression Line)
newX = [[70], [80], [90]]
newY = linear_regressor.predict(newX)
print(newY)
plt.scatter(X, Y, color="blue", label="Data")
plt.plot(X, Y_pred, color="red", label="Regression line")
plt.scatter(newX, newY, color="green", label="Prediction")
plt.legend(loc=1)
plt.show()


ScatterRegressionButton = Button(root,width=100,highlightthickness = 0, bd = 0,bg='#051626',image=ScatterRegressionImage,activebackground='#051626' , command=RegressionLine)
ScatterRegressionButton.place(x=250,y=260)
ValuesLabel=Label(root,text="Values",bg='#051626',fg='white',font=fontStyle)
ValuesLabel.place(x=15,y=420)