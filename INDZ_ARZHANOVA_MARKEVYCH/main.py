# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f' {name}')  # Press Ctrl+F8 to toggle the breakpoint.


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('')


# Основна функція
def main():
    from jacobi import jacobi
    from seidel import seidel
    # Задання матриці коефіцієнтів A
    A = [[4, -1, 1],
         [4, -8, 1],
         [-2, 1, 5]]
    # Задання вектора правої частини b
    b = [7, -21, 15]
    # Початкове наближення x0
    x0 = [0, 0, 0]
    # Точність і максимальна кількість ітерацій
    tolerance = 1e-6
    max_iterations = 100
    solution1 = jacobi(A, b, x0, tolerance, max_iterations)
    print("Solution:", [round(val, 3) for val in solution1])
    solution2 = seidel(A, b, x0, tolerance, max_iterations)
    # Виведення розв'язку
    print("Solution:", [round(val, 3) for val in solution2])

    from equation import solve_linear_equation
    a = 2
    b = -3
    solve_linear_equation(a, b)







# Виклик основної функції
if __name__ == "__main__":
    main()

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
