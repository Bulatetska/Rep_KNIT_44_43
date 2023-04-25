#1
def maxVal(lst):
    max_val = max(lst)
    if max_val >= 0:
        return max_val
    else:
        return "Число менше 0"

my_list = [-1, 3, 7, 2, 5]
my_list2 = [-4, -1]
print("1: ", maxVal(my_list))
print("1: ", maxVal(my_list2))

#2
def lettersCount(word):
    return len(word)

my_word = "Hello"
print("2: ", lettersCount(my_word))

#3
def power(base, exponent):
    if exponent >= 0:
        return base ** exponent
    else:
        return "Степінь не може бути від'ємною"

print("3: ", power(2, 3))
print("3: ", power(3, -2))

#4
def printNums(n):
    for i in range(1, n+1):
        print("  ", i)

print("4: ")
printNums(7)

#5
def recArrea(length, height):
    if (length > 0 and height > 0) and length != height:
        return length * height
    else:
        return "Невірно введені дані"

print("5: ", recArrea(0, 5))
print("5: ", recArrea(3, 5))
