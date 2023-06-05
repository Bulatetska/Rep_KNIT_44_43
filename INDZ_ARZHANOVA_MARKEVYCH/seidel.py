from typing import List

def seidel(A: List[List[float]], b: List[float], x0: List[float], tol: float, max_iter: int) -> List[float]:
    """
    Метод Зейделя для розв'язку системи лінійних рівнянь Ax = b.

    Параметри:
    A (List[List[float]]): Матриця коефіцієнтів рівнянь
    b (List[float]): Вектор правої частини
    x0 (List[float]): Початкове наближення
    tol (float): Точність
    max_iter (int): Максимальна кількість ітерацій

    Повертає:
    List[float]: Розв'язок системи рівнянь x

    Викидає:
    ValueError: Якщо розмірності матриці A, вектора b та початкового наближення x0 не відповідають один одному.
    """

    # Перевірка розмірностей
    n = len(A)
    if len(b) != n or len(x0) != n:
        raise ValueError("Розмірності матриці A, вектора b та початкового наближення x0 повинні співпадати.")

    x = x0.copy()  # Початкове наближення

    for k in range(max_iter):
        x_new = x.copy()  # Нове наближення

        for i in range(n):
            s1 = sum(A[i][j] * x_new[j] for j in range(i))
            s2 = sum(A[i][j] * x[j] for j in range(i+1, n))
            x_new[i] = (b[i] - s1 - s2) / A[i][i]  # Оновлення невідомих

        # Перевірка на збіжність
        if max(abs(x_new[i] - x[i]) for i in range(n)) < tol:
            return [round(val, 3) for val in x_new]

        x = x_new
        return [round(val, 3) for val in x]

    return x