import math
import matplotlib.pyplot as plt
#import Formulas.formulas


x = [ 2,3,0.3,3.3,1.3,0.4,0.2,6.0,5.5,6.5,0.2,2.3,1.5,4.0,5.9,1.8,4.7,0.7,4.5,0.3,1.5,0.5,2.5,5.0,1.0,6.0,5.6,6.0,1.2,0.2]

#Formulas.formulas.getNumberOfClassesForHistogram(x)
plt.hist(x , bins= (math.ceil(math.sqrt(len(x)))) , color='r' )
plt.title("Histogram")
plt.xlabel("x-axis")
plt.ylabel("y-axis")
plt.show()