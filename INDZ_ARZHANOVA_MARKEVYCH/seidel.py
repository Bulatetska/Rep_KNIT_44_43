def seidel(A, b, x0, tol, max_iter):
    n = len(A)
    x = x0.copy()  # Початкове наближення

    for k in range(max_iter):
        x_new = x.copy()  # Нове наближення

        for i in range(n):
            s1 = sum(A[i][j] * x_new[j] for j in range(i))
            s2 = sum(A[i][j] * x[j] for j in range(i+1, n))
            x_new[i] = (b[i] - s1 - s2) / A[i][i]  # Оновлення невідомих

        # Перевірка на збіжність
        if max(abs(x_new[i] - x[i]) for i in range(n)) < tol:
            return x_new

        return [round(val, 3) for val in x_new]

    return x
