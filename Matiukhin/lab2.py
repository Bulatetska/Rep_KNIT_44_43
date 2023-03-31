def discount(price:float, disc:float):
    """
    Ф-ція для обчислння ціни зі знижкою
    """
    return price - price * (disc / 100)


def price(price:float):
    """
    Ф-ція для обчислення знижки на товар
    """
    if(price < 100):
        return price
    elif(price < 500):
        return discount(price, 3)
    elif(price < 1000):
        return discount(price, 5)
    else:
        return discount(price, 10)

def emp2null(str:str):
    """
    Ф-ція, що заміняє пусту стрічку на None 
    """
    return str if str!="" else None

for x in range(100, 1301, 600):
    print(f"Ціна: {x};\t Ціна зі знижкою: {price(x)}")

print(f"Непорожня стрічка: \"{emp2null('AsddsA')}\"")
print(f"Порожня стрічка: \"{emp2null('')}\"")