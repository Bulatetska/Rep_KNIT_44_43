def sort_list(lst):
    """
    Сортує заданий список в порядку зростання.
    """
    return sorted(lst)

def search_by_value(lst, value):
    """
    Знаходить індекс першого елемента в списку, який має задане значення.
    """
    try:
        return lst.index(value)
    except ValueError:
        return -1

def search_sequence(lst, sequence):
    """
    Знаходить індекс першого елемента в списку, з якого починається задана послідовність.
    """
    for i in range(len(lst) - len(sequence) + 1):
        if lst[i:i+len(sequence)] == sequence:
            return i
    return -1

def search_first_min(lst, count=5):
    """
    Знаходить перші count мінімальних елементів у списку.
    """
    return sorted(lst)[:count]

def search_first_max(lst, count=5):
    """
    Знаходить перші count максимальних елементів у списку.
    """
    return sorted(lst, reverse=True)[:count]

def calculate_average(lst):
    """
    Функція для обчислення середнього арифметичного всіх елементів списку.
    """
    if len(lst) == 0:
        return 0
    return sum(lst) / len(lst)

def remove_duplicates(lst):
    """
    Функція що повертає список без повторюваних значень.
    """
    return list(set(lst))