def solve_linear_equation(a, b):
    try:
        if a == 0:
            if b == 0:
                print("Рівняння має безліч розв'язків.")
            else:
                print("Рівняння не має розв'язку.")
        else:
            x = -b / a
            print("Розв'язок рівняння: x =", x)
        return x
    except ZeroDivisionError:
        print("Помилка: Ділення на нуль.")
