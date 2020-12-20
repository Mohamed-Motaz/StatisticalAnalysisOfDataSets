import matplotlib
import matplotlib.pyplot as plt
import numpy as np


labels = ['group_a', 'group_b', 'group_c', 'group_d','group_e','group_f','group_g','group_r','group_t','group_y','group_1', 'group_2', 'group_3', 'group_4','group_5','group_6','group_7','group_8','group_9','group_10']
men_means = [5, 50, 100,70,10,20,40,70,160,500,5, 50, 100,70,10,20,40,70,160,500]


x = np.arange(len(labels))  # the label locations
width = 0.35  # the width of the bars

fig, ax = plt.subplots()
rects1 = ax.bar(x, men_means, width,color="orange",label='men')

# Add some text for labels, title and custom x-axis tick labels, etc.
ax.set_ylabel('Scores')
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