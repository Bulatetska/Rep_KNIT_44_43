MYlist = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print("Task_1")
for i in MYlist:
    if i % 2 == 0:
        MYlist.remove(i)
print(MYlist)

print("Task_2")
for i in range(len(MYlist)):
    MYlist[i] = MYlist[i] ** 2

print(MYlist)

print("Task_3")
max_elem = max(MYlist)

print(max_elem)