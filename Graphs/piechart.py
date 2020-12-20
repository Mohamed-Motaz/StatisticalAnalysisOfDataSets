import matplotlib.pyplot as plt

Tasks = [300,500,700]

my_labels = 'Tasks Pending','Tasks Ongoing','Tasks Completed'
plt.pie(Tasks, labels=my_labels, autopct='%1.1f%%')
plt.title('My Tasks')
plt.axis('equal')
plt.show()