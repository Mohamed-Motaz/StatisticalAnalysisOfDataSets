import matplotlib.pyplot as plt
names = ['group_a', 'group_b', 'group_c', 'group_d']
values = [5, 50, 100,70]
widt=8
height =4
plt.figure(figsize=(widt, height))
plt.bar(names, values,width=0.4 ,color='orange')

plt.ylabel('Values')
plt.xlabel('Groups names')
plt.title('Bar graph')
for index,data in enumerate(values):
    plt.text(x=index , y =data+1 , s=f"{data}" , fontdict=dict(fontsize=20))
  
plt.tight_layout()
plt.show()