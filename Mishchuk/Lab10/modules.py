import print_models
import show_completed_models
import list_functions

unprinted_designs = ['iphone case', 'robot pendant',
'dodecahedron']
completed_models = []
print_models.print_models(unprinted_designs, completed_models)
show_completed_models.show_completed_models(completed_models)


my_list = [1, 4, 5, 7, 1, 3, 5, 6, 7]
print(list_functions.sort_list(my_list))
print(list_functions.search_by_value(my_list, 3))
print(list_functions.search_sequence(my_list, 'abc'))
print(list_functions.search_first_max(my_list))
print(list_functions.calculate_average(my_list))
print(list_functions.remove_duplicates(my_list))