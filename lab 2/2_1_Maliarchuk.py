price = int(input("Input price of item: "))

if price < 100:
    print("There is no discount for items that cost lower than 100.")
else:
    if (price >= 100) and (price < 500):
        discount = 97
    elif (price >=500) and (price < 1000):
        discount = 95
    elif price >= 1000 :
        discount = 90
    
    actual_price = (price * discount) / 100
    print("The price of an item with a discount is: " + str(actual_price))