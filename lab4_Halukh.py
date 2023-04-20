# Задача 1

A = {3, 5, 11, 7, 4, -3}
B = {11, 5, 8, 1, 10, 7}

# виводимо елементи A, яких немає в B
print("Елементи, яких немає в B:", A - B)

# виводимо спільні елементи A та B
print("Спільні елементи A та B:", A & B)

# виводимо об'єднання множин A та B
print("Об'єднання множин A та B:", A | B)


# Задача 2

a = "a14b6fh"
unique_chars = set(a)

if len(a) == len(unique_chars):
    print("Всі символи унікальні")
else:
    print("Є повторювані символи")


# Задача 3

lst = [3, 5, 11, 7, 4, 5, 11, 8, 1, 10, 7]
counts = {}

# рахуємо кількість повторів кожного елементу
for num in lst:
    if num in counts:
        counts[num] += 1
    else:
        counts[num] = 1

# виводимо кількість повторів кожного елементу
for num, count in counts.items():
    print(f"{num} повторюється {count} разів")


# Задача 4

my_dict = {1: 'a', 2: 'b', 3: 'c', 4: 'd', 5: 'e', 6: 'f'}

for key, value in my_dict.items():
    if key % 2 == 0: # перевіряємо, чи ключ є парним
        print(value)


# Задача 5

my_d = {'apple': 1, 'banana': 2, 'apricot': 3, 'carrot': 4, 'avocado': 5}

# Створюємо новий словник, до якого додаємо елементи, які не починаються з "a"
new_d = {}
for key, value in my_d.items():
    if not key.startswith('a'): # перевіряємо, чи значення ключа не починається з "a"
        new_d[key] = value

# Замінюємо старий словник новим
my_d = new_d

print(my_d)