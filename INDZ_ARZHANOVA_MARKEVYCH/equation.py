def solve_linear_equation(a, b):
    """
    Функція для розв'язання лінійного рівняння ax + b = 0.

    Параметри:
    a (float): Коефіцієнт a у рівнянні.
    b (float): Коефіцієнт b у рівнянні.

    Повертає:
    float: Значення x - розв'язок рівняння.

    Винятки:
    ZeroDivisionError: Виникає, якщо a дорівнює нулю.
    """
    try:
        if a == 0:
            if b == 0:
                print("Рівняння має безліч розв'язків.")
            else:
                print("Рівняння не має розв'язку.")
        else:
            x = -b / a

        return x
    except ZeroDivisionError:
        print("Помилка: Ділення на нуль.")
