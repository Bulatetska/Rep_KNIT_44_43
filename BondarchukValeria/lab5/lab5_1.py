def find_max_positive(numbers):
    max_number = max(numbers)
    if max_number > 0:
        return max_number
    else:
        return "Число менше 0"

print(find_max_positive([1, 2, 4, 0, 9, 6, -1]))

print(find_max_positive([-6, -1]))