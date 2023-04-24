my_list = [3, 4, 2, 1, 3, 2, 4, 4, 2, 3, 5, 1]
count = {}

for item in my_list:
    if item in count:
        count[item] += 1
    else:
        count[item] = 1

print(count)
