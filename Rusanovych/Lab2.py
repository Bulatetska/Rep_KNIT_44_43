def calcItemPriceWithSale(price):
    percentOfsale = 0
    if price > 1000:
        percentOfsale = 10
    elif price > 500:
        percentOfsale = 5
    elif price > 100:
        percentOfsale = 3

    if percentOfsale != 0:
        return price * (1 - percentOfsale / 100)
    return price

print(calcItemPriceWithSale(1200))
