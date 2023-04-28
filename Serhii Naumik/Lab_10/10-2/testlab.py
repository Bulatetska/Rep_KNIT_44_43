import list_functions

lst = [3, 7, 1, 5, 9, 3, 8, 2, 5, 7]

sorted_lst = list_functions.sort_list(lst)
print(sorted_lst)
index = list_functions.find_element(lst, 5)
print(index)




index = list_functions.find_sequence(lst, [1, 5, 9])
print(index)





min_lst = list_functions.find_min(lst, 5)
print(min_lst)

max_lst = list_functions.find_max(lst, 5)
print(max_lst)

avg = list_functions.average(lst)
print(avg)

unique_lst = list_functions.remove_duplicates(lst)
print(unique_lst)
