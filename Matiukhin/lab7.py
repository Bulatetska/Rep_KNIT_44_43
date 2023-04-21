import json
import datetime
import random
import os
#------1------
LENGTH = 25
random_string = "".join([chr(random.choice(range(ord('a'), ord('z')))) for x in range(LENGTH)])
os.makedirs("Matiukhin/output/7", exist_ok=True)
with open("Matiukhin/output/7/random_string", "w") as file:
    file.write(random_string)
#------2------
now = datetime.date.today().strftime("%d;%m;%y")
список_користувачів = ["Артур", "Кейт", "Аліса", "Майк"]
список_словників = [{"name":name, "age":random.randint(1,99)} for name in список_користувачів]
список_словників.append({"data":now})
with open("Matiukhin/output/7/user_data_"+now, "w") as file:
    json.dump(список_словників, file)