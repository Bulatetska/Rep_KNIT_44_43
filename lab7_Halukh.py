import random
import string
import json
from datetime import date

# Генерування рядка з 25 випадкових букв
random_string = ''.join(random.choices(string.ascii_letters, k=25))

# Запис рядка у файл
with open('random_string.txt', 'w') as file:
    file.write(random_string)

# Створення списку користувачів
users = ["Артур", "Кейт", "Аліса", "Майк"]

# Створення списку словників
users_data = []
for user in users:
    user_data = {
        "name": user,
        "age": random.randint(1, 99)
    }
    users_data.append(user_data)

# Створення словника з додатковими даними
final_data = {
    "data": users_data,
    "created_at": date.today().strftime("%d;%m;%y")
}

# Запис словника у JSON файл
filename = f"users_data_{date.today()}.json"
with open(filename, 'w') as file:
    json.dump(final_data, file)