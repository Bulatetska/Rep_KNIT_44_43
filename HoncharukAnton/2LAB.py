price = float(input("Введіть вартість товару: "))

if price > 1000:
    discount = 0.1
elif price > 500:
    discount = 0.05
elif price > 100:
    discount = 0.03
else:
    discount = 0

discount_amount = price * discount
final_price = price - discount_amount

print("Знижка: ", discount_amount)
print("Вартість товару з урахуванням знижки: ", final_price)