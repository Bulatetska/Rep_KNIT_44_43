my_dict = {1:"apple",2: "banana", 3:"apricot", 4:"peach", 5:"airplane",6: "house"}
keys_to_remove = []

for key, value in my_dict.items():
    if str(value).startswith('a'):
        keys_to_remove.append(key)

for key in keys_to_remove:
    del my_dict[key]

print(my_dict)