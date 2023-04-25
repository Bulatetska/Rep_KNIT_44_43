def calc_price(val):
    if val > 1000:
        return val - val * 0.1
    if val > 500:
        return val - val * 0.05
    if val > 100:
        return val - val * 0.01
    return val

def calc_price_tern(val):
    return val - val*0.1 if val > 1000 else val - val*0.05 if val > 500 else val - val*0.01 if val > 100 else val


print(calc_price(2000))

print(calc_price_tern(2000))