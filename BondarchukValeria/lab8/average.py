# Назва модуля: average

def calc_average(num_list):
    """Обчислює середнє арифметичне чисел у списку."""
    if not num_list:
        return 0
    return sum(num_list) / len(num_list)
