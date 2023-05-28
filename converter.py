def convert_length(value, unit):
    if unit == 'см':
        return value
    elif unit == 'м':
        return value / 100
    elif unit == 'км':
        return value * 1000
    elif unit == 'ft':
        return value * 0.3048
    elif unit == 'in':
        return value * 0.0254
    else:
        return 'Невідома одиниця виміру довжини'


def convert_weight(value, unit):
    if unit == 'кг':
        return value
    elif unit == 'г':
        return value / 1000
    elif unit == 'lb':
        return value * 0.453592
    elif unit == 'oz':
        return value * 0.0283495
    else:
        return 'Невідома одиниця виміру маси'


def convert_temperature(value, unit):
    if unit == 'C':
        return value
    elif unit == 'F':
        return (value - 32) * 5 / 9
    elif unit == 'K':
        return value - 273.15
    else:
        return 'Невідома одиниця виміру температури'