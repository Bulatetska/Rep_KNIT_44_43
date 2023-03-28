lst = [1, 2, 3, 4, 1, 2, 5, 6, 1, 2, 7, 8]
count_dict = {}
for element in lst:
    if element in count_dict:
        count_dict[element] += 1
    else:
        count_dict[element] = 1
print(count_dict)