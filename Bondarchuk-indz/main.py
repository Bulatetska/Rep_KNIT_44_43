from tkinter import Tk, RIDGE
from game_logic import start_game
from gui import create_gui

"""
Правила гри:
Комп'ютер генерує чотиризначне число. Всі цифри повинні бути різні.
Гравець повинен відгадати це число. Він пропонує свій варіант, а комп'ютер дає кількість збігів.
Якщо збігається цифра в її правильній позиції, то це є «бик», якщо не в своїй позиції — це «корова».

Наприклад:
Задумане число: 4271
Спроба гравця: 1234
Відповідь: 1 бика і 2 корови. (Бик "2", корови "4" і "1".)
"""

def main():
    """
    Головна функція програми. Створює та налаштовує графічний інтерфейс гри "Бики та корови".

    Returns:
        None
    """
    root = Tk()
    root.title("Бики та корови")
    root.geometry("680x500")
    root.configure(borderwidth=10, relief=RIDGE)
    root.iconbitmap("cow.ico")

    create_gui(root, start_game)

    root.mainloop()

if __name__ == "__main__":
    main()
