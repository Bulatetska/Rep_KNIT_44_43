def sort_list(lst):
    """
    Сортує список за зростанням.

    Args:
        lst (list): список елементів

    Returns:
        list: відсортований список
    """
    return sorted(lst)


def find_element(lst, elem):
    """
    Повертає індекс першого входження заданого елементу в список.

    Args:
        lst (list): список елементів
        elem: шуканий елемент

    Returns:
        int: індекс першого входження шуканого елементу або -1, якщо елемент не знайдено
    """
    try:
        return lst.index(elem)
    except ValueError:
        return -1


def find_sequence(lst, seq):
    """
    Повертає список індексів початку послідовностей, які співпадають із заданою послідовністю.

    Args:
        lst (list): список елементів
        seq (list): послідовність елементів, яку треба знайти

    Returns:
        list: список індексів, де починається знайдена послідовність
    """
    seq_len = len(seq)
    indices = []
    for i in range(len(lst) - seq_len + 1):
        if lst[i:i+seq_len] == seq:
            indices.append(i)
    return indices


def find_first_n_min(lst, n):
    """
    Повертає перші n мінімальних елементів у вигляді списку.

    Args:
        lst (list): список елементів
        n (int): кількість мінімальних елементів, які потрібно знайти

    Returns:
        list: список перших n мінімальних елементів
    """
    return sorted(lst)[:n]


def find_first_n_max(lst, n):
    """
    Повертає перші n максимальних елементів у вигляді списку.

    Args:
        lst (list): список елементів
        n (int): кількість максимальних елементів, які потрібно знайти

    Returns:
        list: список перших n максимальних елементів
    """
    return sorted(lst, reverse=True)[:n]


def calculate_mean(lst):
    """
    Обчислює середнє арифметичне елементів списку.

    Args:
        lst (list): список елементів

    Returns:
        float: середнє арифметичне елементів списку
    """
    if not lst:
        return 0
    return sum(lst) / len(lst)

def unique_list(input_list):
    """
    Повертає новий список, що містить лише унікальні елементи з вхідного списку.
    
    Args:
    input_list (list): Початковий список.
    
    Returns:
    list: Новий список, що містить лише унікальні елементи з вхідного списку.
    """
    output_list = []
    for element in input_list:
        if element not in output_list:
            output_list.append(element)
    return output_list
