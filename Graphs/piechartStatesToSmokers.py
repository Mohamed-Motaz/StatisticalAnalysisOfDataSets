import matplotlib.pyplot as plt
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = deathsPerState
z = percentageSmokersPerState
Tasks = z

my_labels = x

plt.pie(Tasks, labels=my_labels, autopct='%1.1f%%', startangle=15, shadow = True)
plt.title('Perecentage Smokers Per State')
plt.axis('equal')
plt.show()