def jacobi(A, b, x0, tol, max_iter):
    n = len(A)
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
