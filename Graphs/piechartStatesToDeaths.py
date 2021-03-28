import matplotlib.pyplot as plt
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = percentageSmokersPerState
Tasks = y

my_labels = x

#autopct shows the values on the pie chart and shows them as float (%1.1f)
plt.pie(Tasks, labels=my_labels, autopct='%1.1f%%', startangle=15, shadow = True)
plt.title('Percentage of Deaths')
plt.axis('equal')
plt.show()