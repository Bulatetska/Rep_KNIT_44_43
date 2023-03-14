price = int(input())
discount = 0
if price > 100:
	discount = price * 0.03
elif price > 500:
	discount = price * 0.05
elif price > 1000:
	discount = price * 0.1
result = price - discount
print(result)

