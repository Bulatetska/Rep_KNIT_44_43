from converter import convert_length, convert_weight, convert_temperature
import text_processing
import grades

print("======================================Serhii Naumik=============================================")
text = "Hello, teacher, I am a student - Naumik Serhii, I am handing in the completed assignment!"

cleaned_text = text_processing.clean_text(text)
print(cleaned_text) 

word_count = text_processing.count_words(text)
print(word_count)

reversed_text = text_processing.reverse_text(text)
print(reversed_text)

capitalized_text = text_processing.capitalize_text(text)
print(capitalized_text)

print("======================================Nadia Vitkoveth=============================================")

# Списки оцінок та прізвищ учнів
grades_list = [80, 90, 75, 85, 95]
names_list = ["Smith", "Johnson", "Williams", "Jones", "Brown"]
for i in range(len(names_list)):
    name = names_list[i]
    grade = grades_list[i]
    print(f"{name}: {grade}")
# Обчислення середнього балу
average_grade = grades.calculate_average(grades_list)
print("Середній бал:", average_grade)

# Пошук учня з найвищою оцінкою
highest_student, highest_grade = grades.find_highest_grade(grades_list, names_list)
print("Учень з найвищою оцінкою:", highest_student, "Оцінка:", highest_grade)

# Пошук учня з найнижчою оцінкою
lowest_student, lowest_grade = grades.find_lowest_grade(grades_list, names_list)
print("Учень з найнижчою оцінкою:", lowest_student, "Оцінка:", lowest_grade)

# Сортування за зростанням оцінок
sorted_grades, sorted_names = zip(*sorted(zip(grades_list, names_list)))

# Виведення оцінок біля прізвищ учнів
for i in range(len(sorted_names)):
    name = sorted_names[i]
    grade = sorted_grades[i]
    print(f"{name}: {grade}")

print("======================================Zubok Diana=============================================")


value = float(input('Введіть значення: '))
unit_type = input('Введіть тип величини (довжина, маса, температура): ')

if unit_type == 'довжина':
    unit = input('Введіть одиницю виміру (см, м, км, ft, in): ')
    result = convert_length(value, unit)
    print(f'Результат: {result} {unit}')
elif unit_type == 'маса':
    unit = input('Введіть одиницю виміру (кг, г, lb, oz): ')
    result = convert_weight(value, unit)
    print(f'Результат: {result} {unit}')
elif unit_type == 'температура':
    unit = input('Введіть одиницю виміру (C, F, K): ')
    result = convert_temperature(value, unit)
    print(f'Результат: {result} {unit}')
else:
    print('Невідомий тип величини')
