import numpy as np
import matplotlib.pyplot as plt

def f(x, y):
    return x + np.sin(y / np.sqrt(11))

# Метод Ейлера
def euler_method(x0, y0, h, xf):
    x_values = [x0]
    y_values = [y0]

    while x_values[-1] < xf:
        y = y_values[-1] + h * f(x_values[-1], y_values[-1])
        x = x_values[-1] + h
        x_values.append(x)
        y_values.append(y)

    return x_values, y_values

# Задані початкові умови
x0 = 0.6
y0 = 1.2
h = 0.1
xf = 1.6

# Обчислення розв'язку методом Ейлера
x_euler, y_euler = euler_method(x0, y0, h, xf)

# Побудова графіку розв'язку та ламаної Ейлера
plt.plot(x_euler, y_euler, label='Euler\'s method')
plt.scatter(x_euler, y_euler, color='red')

# Налаштування графіку
plt.xlabel('x')
plt.ylabel('y')
plt.title('Euler\'s method')
plt.legend()
plt.grid(True)

# Показати графік
plt.show()
