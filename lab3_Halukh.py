my_list = [1, 2, 3, 4, 5, 6, 7, 8, 9]

# видалення всіх парних елементів
new_list = []
for num in my_list:
    if num % 2 != 0:
        new_list.append(num)

my_list = new_list

# піднесення до квадрату всіх елементів
my_list = [pow(x, 2) for x in my_list]

# знаходження максимального елементу
max_element = max(my_list)

print(my_list)
print(max_element)
