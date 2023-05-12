import functions

input_list = [1, 2, 3, 2, 4, 5, 4, 6, 7, 7, 8, 9, 9]

sort_list = functions.sort_list(input_list)
print(sort_list)

find_el = functions.find_element(input_list, 7)
print(find_el)

find_seq = functions.find_sequence(input_list, [2, 4, 5])
print(find_seq)

find_min = functions.find_first_n_min(input_list, 2)
print(find_min)

find_max = functions.find_first_n_max(input_list, 3)
print(find_max)

find_mean = functions.calculate_mean(input_list)
print(find_mean)

unique_list = functions.unique_list(input_list)
print(unique_list)
