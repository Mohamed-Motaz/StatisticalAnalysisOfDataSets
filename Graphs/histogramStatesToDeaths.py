import math
import matplotlib.pyplot as plt
#import Formulas.formulas
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = percentageSmokersPerState


plt.hist(y , bins= (math.ceil(math.sqrt(len(y)))) , color='r' )
#bins is class width

plt.title("Histogram")
plt.xlabel("Percentage of Deaths")
plt.ylabel("Frequency")
plt.show()