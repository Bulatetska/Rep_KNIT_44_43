import random

i = 0
lst = []
while i < 25:
    number = random.randint(65, 90) # число від 0 до 100
    lst = lst + [chr(number)]
    i = i+1

f = open('random_string.txt', 'wt')

for i in lst:
    s = str(i) # конвертувати елемент списку в рядок
    f.write(s + ' ') # записати числа в рядок

f.close()