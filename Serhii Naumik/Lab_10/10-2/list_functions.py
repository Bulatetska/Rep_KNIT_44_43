def sort_list(lst):
    """
    Сортує список в порядку зростання.
    """
    return sorted(lst)

def find_element(lst, elem):
    """
    Повертає індекс першого входження елементу в список.
    Якщо елемент не знайдено, повертає -1.
    """
    try:
        return lst.index(elem)
    except ValueError:
        return -1

def find_sequence(lst, seq):
    """
    Повертає індекс першого входження послідовності елементів у список.
    Якщо послідовність не знайдено, повертає -1.
    """
    n = len(seq)
    for i in range(len(lst)-n+1):
        if lst[i:i+n] == seq:
            return i
    return -1

def find_min(lst, n=5):
    """
    Повертає список перших n мінімальних елементів.
    """
    return sorted(lst)[:n]

def find_max(lst, n=5):
    """
    Повертає список перших n максимальних елементів.
    """
    return sorted(lst, reverse=True)[:n]

def average(lst):
    """
    Повертає середнє арифметичне значення елементів списку.
    """
    return sum(lst) / len(lst)

def remove_duplicates(lst):
    """
    Повертає список, що сформований з початкового списку,
    але не містить повторів (залишається лише перший з однакових елементів).
    """
    return list(dict.fromkeys(lst))
