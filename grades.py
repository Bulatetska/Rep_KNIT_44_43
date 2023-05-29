def calculate_average(grades):
    total = sum(grades)
    average = total / len(grades)
    return average

def find_highest_grade(grades, names):
    highest_grade = max(grades)
    index = grades.index(highest_grade)
    student_name = names[index]
    return student_name, highest_grade

def find_lowest_grade(grades, names):
    lowest_grade = min(grades)
    index = grades.index(lowest_grade)
    student_name = names[index]
    return student_name, lowest_grade

def sort_grades(grades, names, reverse=False):
    sorted_grades = [grade for grade, _ in sorted(zip(grades, names), key=lambda x: x[0], reverse=reverse)]
    sorted_names = [name for _, name in sorted(zip(grades, names), key=lambda x: x[0], reverse=reverse)]
    return sorted_grades, sorted_names
