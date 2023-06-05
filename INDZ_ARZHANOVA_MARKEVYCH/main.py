# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


def print_hi(name):
    print(f'Hi, {name}')


if __name__ == '__main__':
    print_hi('PyCharm')


def main():
    from jacobi import jacobi
    A = [[4, -1, 1],
         [4, -8, 1],
         [-2, 1, 5]]
    b = [7, -21, 15]
    x0 = [0, 0, 0]
    tolerance = 1e-6
    max_iterations = 100
    solution = jacobi(A, b, x0, tolerance, max_iterations)
    print("Solution:", [round(val, 3) for val in solution])

    from equation import solve_linear_equation

    a = 2
    b = -3
    solution =solve_linear_equation(a, b)
    print("Solution:", solution)


from seidel import seidel

A = [[4, -1, 1],
     [4, -8, 1],
     [-2, 1, 5]]

b = [7, -21, 15]

x0 = [0, 0, 0]

tolerance = 1e-6
max_iterations = 100

solution = seidel(A, b, x0, tolerance, max_iterations)

print("Solution:", [round(val, 3) for val in solution])



if __name__ == "__main__":
    main()





# See PyCharm help at https://www.jetbrains.com/help/pycharm/
