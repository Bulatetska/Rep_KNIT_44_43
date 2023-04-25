import json
import random
import string
from datetime import datetime

users = ["Артур", "Кейт", "Аліса", "Майк"]

users_list = []
for user in users:
    user_data = {
        "name": user,
        "age": random.randint(1, 99)
    }
    users_list.append(user_data)

current_date = datetime.now().strftime("%d;%m;%y")

final_data = {
    "data": users_list,
    "created_at": current_date
}

with open(f'users_data_{current_date}.json', 'w') as file:
    json.dump(final_data, file)