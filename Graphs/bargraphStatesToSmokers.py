import matplotlib
import matplotlib.pyplot as plt
import numpy as np
import dataSetImport
stateNames, percentageDeathsPerState, percentageSmokersPerState = dataSetImport.run()


x = stateNames
y = percentageDeathsPerState
z = dataSetImport.turnPercentageFromFloatToInt(percentageSmokersPerState)


labels = x
smokersInState = z


x = np.arange(len(labels))  
width = 0.35  #

fig, ax = plt.subplots()
rects1 = ax.bar(x, smokersInState, width,color="orange",label='Deaths')

ax.set_ylabel('Percentage of Smokers')
ax.set_xlabel('States')
ax.set_xticks(x)
ax.set_xticklabels(labels)
ax.legend()


def autolabel(rects):
    """Attach a text label above each bar in rects, displaying its height."""
    for rect in rects:
        height = rect.get_height()
        ax.annotate('{}'.format(height),
                    xy=(rect.get_x() + rect.get_width() / 2, height),
                    xytext=(0, 3),  # 3 points vertical offset
                    textcoords="offset points",
                    ha='center', va='bottom')


autolabel(rects1)

fig.tight_layout()

plt.show()