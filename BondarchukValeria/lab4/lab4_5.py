my_dict = {"red": "apple", "yellow": "banana", "orange": "carrot", "green": "avocado"}

for key in list(my_dict.keys()):
    if my_dict[key].startswith("a"):
        del my_dict[key]

print(my_dict)
