import random
array = []
for x in range(0,20):
    array.append(random.randint(0, x))
print("Список: " + str(array))

array = list(filter(lambda x: x%2 != 0, array))
print("Список без парних: " + str(array))

for i, x in enumerate(array):
    array[i] = pow(x,2);
print("Список в квадраті: " + str(array))

print("Максимальний елемент списку: " + str(max(array)))