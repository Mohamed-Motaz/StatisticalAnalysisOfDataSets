#salma
import matplotlib.pyplot as plt

Tasks = [300,500,700]

my_labels = 'Tasks Pending','Tasks Ongoing','Tasks Completed'
my_colors = ['lightblue','lightsteelblue','silver']
my_explode = (0, 0.1, 0)
plt.pie(Tasks, labels=my_labels, autopct='%1.1f%%', startangle=15, shadow = True, colors=my_colors, explode=my_explode)
plt.title('My Tasks')
plt.axis('equal')
plt.show()