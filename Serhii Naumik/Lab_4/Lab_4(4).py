a = "a14b6fh"
# Використання множин
unique_set = set(a)
if len(a) == len(unique_set):
    print("Усі символи унікальні (використано множини)")
else:
    print("Є повторювані символи (використано множини)")

# Використання списків
unique_list = []
for char in a:
    if char not in unique_list:
        unique_list.append(char)
if len(a) == len(unique_list):
    print("Усі символи унікальні (використано списки)")
else:
    print("Є повторювані символи (використано списки)")