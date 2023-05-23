from random import randint
from tkinter import END

def start_game(st0):
    """
    Генерує початкове значення st0 - таємний код.

    Args:
        st0 (str): Поточне значення st0.

    Returns:
        str: Згенероване початкове значення st0.
    """
    if st0 == '':
        st0 = ''
        while len(st0) < 4:
            a = str(randint(0, 9))
            if a in st0:
                continue
            else:
                st0 = st0 + a
    check_default_value(st0)
    return st0

def sproba(num, EntryB):
    """
    Інкрементує значення num та виводить його в EntryB.

    Args:
        num (list): Список, що містить значення num.
        EntryB (Entry): Об'єкт Entry для виводу результату.

    Returns:
        list: Збільшене значення num.
    """
    num[0] += 1
    num1 = str(num[0])
    EntryB.delete(0, END)
    EntryB.insert(0, num1)
    return num

def check_default_value(st0):
    """
    Перевіряє поточне значення st0.

    Args:
        st0 (str): Поточне значення st0.

    Returns:
        str: Поточне значення st0.
    """
    if len(st0) != 4 or not st0.isdigit():
        return ''
    return st0

def check_bulls_cows(st0, st):
    """
    Перевіряє кількість биків та корів у двох числах.

    Параметри:
    - st0 (str): Загадане число
    - st (str): Запропоноване число

    Повертає:
    tuple: Кортеж, що містить кількість биків та корів

    Приклад використання:
    >>> check_bulls_cows('1234', '5678')
    (0, 0)
    >>> check_bulls_cows('1234', '1256')
    (2, 0)
    >>> check_bulls_cows('1234', '1234')
    (4, 0)
    >>> check_bulls_cows('1234', '4321')
    (0, 4)
    """
    bulls = 0
    cows = 0
   
    ls = list(st)
    ls0 = list(st0)

    for j in range(4):
        if ls[j] == ls0[j]:
            bulls += 1
   
    
    for j in range(4):
        n = ls[j]
        for k in range(4):
            if n == ls0[k]:
                cows += 1
                
    return bulls, cows - bulls


def are_digits_unique(number):
    """
    Перевіряє, чи всі цифри в числі є різними.

    Параметри:
        number (int): Число, для якого перевіряється унікальність цифр.

    Повертає:
        bool: True, якщо всі цифри різні; False, якщо є повторювані цифри.
    """
    digits = [int(d) for d in str(number)]
    return len(set(digits)) == len(digits)