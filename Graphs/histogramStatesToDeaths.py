import math
import matplotlib.pyplot as plt
#import Formulas.formulas
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = deathsPerState
z = percentageSmokersPerState


plt.hist(y , bins= (math.ceil(math.sqrt(len(y)))) , color='r' )
plt.title("Histogram")
plt.xlabel("Deaths Per State")
plt.ylabel("Frequency")
plt.show()