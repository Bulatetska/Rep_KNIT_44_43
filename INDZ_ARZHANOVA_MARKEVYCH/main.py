# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


def print_hi(name):
    # Use a breakpoint in the code line below to debug your script.
    print(f'Hi, {name}')  # Press Ctrl+F8 to toggle the breakpoint.


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('PyCharm')


# Основна функція
def main():
    from jacobi import jacobi
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
    solution = jacobi(A, b, x0, tolerance, max_iterations)
    print("Solution:", [round(val, 3) for val in solution])

    from equation import solve_linear_equation

    a = 2
    b = -3
    solve_linear_equation(a, b)

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

# Виклик функції seidel
solution = seidel(A, b, x0, tolerance, max_iterations)

# Виведення розв'язку
print("Solution:", [round(val, 3) for val in solution])



# Виклик основної функції
if __name__ == "__main__":
    main()
import unittest
from equation import solve_linear_equation
class LinearEquationTest(unittest.TestCase):
    def test_solve_linear_equation(self):
        a = 2
        b = -3
        expected_solution = 1.5

        actual_solution = solve_linear_equation(a, b)

        self.assertAlmostEqual(actual_solution, expected_solution, places=3)
        print("Результат тесту:", actual_solution)
if __name__ == '__main__':
    unittest.main()


import unittest
from jacobi import jacobi

class JacobiTest(unittest.TestCase):
    def test_jacobi(self):
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
        expected_solution = [1.75, 3.5, 3.0]

        actual_solution = jacobi(A, b, x0, tolerance, max_iterations)

        self.assertEqual(actual_solution, expected_solution)

if __name__ == '__main__':
    unittest.main()
# See PyCharm help at https://www.jetbrains.com/help/pycharm/
