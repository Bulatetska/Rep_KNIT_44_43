import string
import random

# згенеруємо рядок з 25 випадкових букв
random_string = ''.join(random.choices(string.ascii_lowercase, k=25))

# відкриємо файл у режимі запису та запишемо у нього рядок
with open('random_string.txt', 'w') as file:
    file.write(random_string)
