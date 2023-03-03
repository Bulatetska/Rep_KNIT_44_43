price = float(input("Введіть вартість товару: "))

discount = 0

if price > 100:
    discount = 0.03
elif price > 500:
    discount = 0.05
elif price > 1000:
    discount = 0.1

discounted_price = price - (price * discount)

print("Ціна зі знижкою:", discounted_price)
