A = {3, 5, 11, 7, 4, -3}
B = {11, 5, 8, 1, 10, 7}

# Вивід елементів A, яких немає в B
print("Елементи A, яких немає в B:")
for element in A:
    if element not in B:
        print(element)

# Вивід спільних елементів А та В
print("Спільні елементи А та В:")
for element in A:
    if element in B:
        print(element)

# Вивід об'єднання множин А та В
print("Об'єднання множин А та В:")
union = A.union(B)
print(union)

