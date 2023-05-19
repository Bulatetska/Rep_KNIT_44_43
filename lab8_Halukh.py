import my_module

# Запитуємо користувача про число
num = int(input("Введіть число: "))

# Обчислюємо факторіал за допомогою функції з модуля my_module
fact = my_module.factorial(num)

# Виводимо результат
print("Факторіал числа", num, "дорівнює", fact)