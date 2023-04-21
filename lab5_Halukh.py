#zavd1:

def max_element(s):
    return max(s)

a = [1, 2, 3, 4, 5, 6, 7, 8, 9]

if max_element(a) == 0:
    print("що число менше 0")
else: print("Максимальне число: ", max_element(a))

#zavd2:

def length(s):
    return len(s)

str = "Anna"

print("Кількість символів: ", length(str))

#zavd3:

def power(num, step):
    if step > 0:
        return pow(num, step)
    else:
        return "Введіть коректний степінь"

print("Степінь: ", power(4,2))
print("Степінь: ", power(2,-2))

#zavd4:

def num_list(n):
    for num in range(1,n+1):
        print(num)


num_list(10)

def square(a,b):
    return a*b

print("Площа прямокутника:", square(3,4))
