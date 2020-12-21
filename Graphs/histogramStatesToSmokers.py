import math
import matplotlib.pyplot as plt
#import Formulas.formulas
import dataSetImport
stateNames, deathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = deathsPerState
z = percentageSmokersPerState


plt.hist(z , bins= (math.ceil(math.sqrt(len(z)))) , color='r' )
plt.title("Histogram")
plt.xlabel("Percentage of Smokers")
plt.ylabel("Frequency")
plt.show()