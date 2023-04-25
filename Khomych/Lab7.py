import random
import string
from datetime import date
import json

with open("random_string", "w") as f:
    f.write("".join(random.choice(string.ascii_letters) for i in range(25)))


d = {"data": [{"name": user, "age": (int("".join(random.choice(string.digits) for i in range(2))) % 99) + 1 } for user in ["Артур", "Кейт", "Аліса", "Майк"]], "created_at": date.today().strftime("%d;%m;%y")}
with open(f"{d['created_at']}.json", "w", encoding='utf-8') as f:
    j = json.dumps(d, indent=4, ensure_ascii=False)
    print(j, file=f)