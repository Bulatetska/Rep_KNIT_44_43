def MyMax(lst:list):
    x = max(lst)
    return x if (x>0) else "Число менше 0"

def WordLength(str:str):
    return len(str)

def MyPow(a,b):
    return pow(a,b) if(b>=0) else "ERR b < 0 RRE"

def Nums(n:int):
    for x in range(1, n+1):
        print(x, end=" ")
    print();

def RectS(w,h):
    return w*h;

print(f"Максимальне з [1, 4, 5, 2]: {MyMax([1, 4, 5, 2])}")
print(f"Максимальне з [-1, -4, -5, -2]: {MyMax([-1, -4, -5, -2])}")
print(f"У слові \"Україна\" є {WordLength('Україна')} букв(а)")
print(f"5 y cтепені 8 = {MyPow(5, 8)}")
print(f"5 y cтепені -8 = {MyPow(5, -8)}")
print("Числа від 1 до 10:")
Nums(10)
print(f"Площа прямокутника з висотою 4 і шириною 9 = {RectS(9, 4)}")