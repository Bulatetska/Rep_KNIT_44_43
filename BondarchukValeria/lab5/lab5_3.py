def pow(param, step):
    if step >= 0:
        return param ** step
    else:
        return "Степінь має бути не менше 0"
    
print(pow(2, 3))

print(pow(3, -1))
