def sort_list(lst):
    """Сортує список у порядку зростання."""
    return sorted(lst)


def find_element(lst, element):
    """Повертає перший індекс елемента у списку, якщо він присутній.
    Якщо елемент не знайдений, повертає -1.
    """
    if element in lst:
        return lst.index(element)
    else:
        return -1


def find_sequence(lst, sequence):
    """Повертає перший індекс початку послідовності елементів у списку,
    якщо вона присутня. Якщо послідовність не знайдена, повертає -1.
    """
    n = len(sequence)
    for i in range(len(lst) - n + 1):
        if lst[i:i+n] == sequence:
            return i
    return -1


def find_first_five_min(lst):
    """Повертає перші п'ять мінімальних елементів у списку."""
    return sorted(lst)[:5]


def find_first_five_max(lst):
    """Повертає перші п'ять максимальних елементів у списку."""
    return sorted(lst, reverse=True)[:5]


def calculate_average(lst):
    """Повертає середнє арифметичне значень у списку."""
    return sum(lst) / len(lst)


def remove_duplicates(lst):
    """Повертає список, у якому зберігається лише перший з
    однакових елементів з початкового списку.
    """
    return list(dict.fromkeys(lst))