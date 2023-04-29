import random
import datetime
import json
# 1.
i = 0
lst = []
while i < 25:
    number = random.randint(65, 90)
    lst = lst + [chr(number)]
    i = i+1
f = open('random_string.txt', 'wt')
for i in lst:
    s = str(i)  # конвертувати елемент списку в рядок
    f.write(s + ' ')  # записати числа в рядок
f.close()

# 2.
users = ["Артур", "Кейт", "Аліса", "Майк"]
users_data = [{"name": name, "age": random.randint(1, 99)} for name in users]
data = {
    "data": users_data,
    "created_at": datetime.datetime.now().strftime("%d;%m;%y")
}
current_date = datetime.datetime.now().strftime("%d;%m;%y")
file_name = "users_data_"+current_date+".json"
with open(file_name, 'w') as file:
    json.dump(data, file, ensure_ascii=False, indent=4)
