def find_max(numbers):
    max_number = max(numbers)
    if max_number > 0:
        return max_number
    else:
        return "Число менше 0"
    
def count_letters(word):
    return len(word)

def power(base, exponent):
    if exponent < 0:
        return "Степінь повинен бути не від'ємним числом."
    else:
        return base ** exponent
    
def print_numbers(n):
    for i in range(1, n+1):
         print(i, end=' ')

def rectangle_area(height, width):
    area = height * width
    return area


numbers = [3, 7, 1, 9, 2]
max_number = find_max(numbers)
print("\n")
print("Максимальне значення в списку ", numbers , " = " , max_number)

word = "Hello"
letter_count = count_letters(word)
print("\n")
print("В слові ", word , letter_count, " літер")


base = 2
exponent = 3
result = power(base, exponent)
print("\n")
print(base , " в степені" , exponent, " = ", result )

n = 10
print("\n")
print("Числа від 1 до N: ")
print_numbers(n)

h = 10
w = 20
area = rectangle_area(h, w)
print("\n")
print("Площа прямокутника: ", area)