import json
import datetime
import random

users = ["Артур", "Кейт", "Аліса", "Майк"]
users_data = []
for user in users:
    user_data = {"name": user, "age": random.randint(1, 99)}
    users_data.append(user_data)

current_date = datetime.datetime.now().strftime("%d;%m;%y")
final_data = {"data": users_data, "created_at": current_date}

filename = f"users_data_{current_date}.json"
with open(filename, "w") as f:
    json.dump(final_data, f, ensure_ascii=False, indent=4)
