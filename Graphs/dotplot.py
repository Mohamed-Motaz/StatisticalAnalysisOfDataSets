#rawan
import matplotlib.pyplot as plt
xvalues=[2, 2, 2, 2, 1, 1 ,1 , 1, 5, 5, 6]
yvalues=[10, 12, 13, 15, 10, 11, 12, 13, 10, 10, 10]
plt.plot(xvalues, yvalues, 'go', markersize=8)

# axis labeling
plt.xlabel('Numbers')
plt.ylabel('Values')

# figure name
plt.title('Dot plot graph')
plt.show()