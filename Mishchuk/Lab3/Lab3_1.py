my_list = list(range(10))
i = 0
while(i < len(my_list)):
   if (my_list[i] % 2 == 0):
      my_list.remove(my_list[i])
      i+=1
print(my_list)
