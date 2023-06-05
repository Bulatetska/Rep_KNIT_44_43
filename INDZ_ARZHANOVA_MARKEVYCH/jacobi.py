def jacobi(A, b, x0, tol, max_iter):
    """
    Виконує ітераційний метод Якобі для розв'язку системи лінійних рівнянь Ax = b.

    Параметри:
    A (list of list): Матриця коефіцієнтів рівнянь.
    b (list): Вектор правої частини рівнянь.
    x0 (list): Початкове наближення.
    tol (float): Точність збіжності.
    max_iter (int): Максимальна кількість ітерацій.

    Повертає:
    list: Розв'язок системи рівнянь.

    Викидає:
    ValueError: Якщо розмірності матриці та вектора не відповідають.
    """

    n = len(A)
    if n != len(b) or n != len(x0):
        raise ValueError("Розмірності матриці A, вектора b та початкового наближення x0 повинні збігатися.")

    x = x0.copy()  # Початкове наближення

    for k in range(max_iter):
        x_new = x.copy()  # Нове наближення

        for i in range(n):
            s = 0.0
            for j in range(n):
                if j != i:
                    s += A[i][j] * x[j]
            x_new[i] = (b[i] - s) / A[i][i]  # Оновлення невідомих

        # Перевірка на збіжність
        if max(abs(x_new[i] - x[i]) for i in range(n)) < tol:
            return x_new

        return [round(val, 3) for val in x_new]

    return x
