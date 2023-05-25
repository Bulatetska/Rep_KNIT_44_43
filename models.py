from printing_functions import *

from utils import *

unprinted_designs = ['iphone case', 'robot pendant', 'dodecahedron']
completed_models = []
print_models(unprinted_designs, completed_models)
show_completed_models(completed_models)

lst = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5]

sorted_lst = sort_list(lst)
print("Sorted list:", sorted_lst)

index = find_element(lst, 9)
print("Index of element 9:", index)

sequence_index = find_sequence(lst, [1, 5, 9])
print("Index of sequence [1, 5, 9]:", sequence_index)

first_five_min = find_first_five_min(lst)
print("First five minimum elements:", first_five_min)

first_five_max = find_first_five_max(lst)
print("First five maximum elements:", first_five_max)

average = calculate_average(lst)
print("Average:", average)

deduplicated_lst = remove_duplicates(lst)
print("List with duplicates removed:", deduplicated_lst)