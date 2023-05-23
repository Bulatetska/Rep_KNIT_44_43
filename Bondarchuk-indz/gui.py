from tkinter import *
from game_logic import sproba, check_default_value, check_bulls_cows, are_digits_unique

st0 = ''
num = [0]
won = False

def create_gui(root, start_game):
    """
    Створює графічний інтерфейс для гри "Бики та корови".

    Args:
        root: Об'єкт кореневого вікна Tkinter.
        start_game: Функція, що ініціалізує початок гри.

    Returns:
        None
    """
    frame1 = Frame(root)
    frame1.grid(row=0, column=0, sticky=N+E+W+S)

    frame2 = Frame(root)
    frame2.grid(row=0, column=1, sticky=N+E+W+S)

    frame3 = Frame(root)
    frame3.grid(row=1, column=1, sticky=N+E+W+S)

    Label(frame1, text='Введіть 4-х значне число', font=('arial', 16)).grid(row=0, pady=5, sticky=S)

    EntryA = Entry(frame1, width=10, font='Arial 20')
    EntryA.grid(row=1, column=0,pady=5, sticky=S)

    button2 = Button(frame1, text="Перевірка",font=('arial', 16),command=lambda: perevirka2(EntryA, EntryB, listbox1, start_game))
    button2.grid(row=3, column=0, pady=5,sticky=S)

    button3 = Button(root, text="Вихід", width=10, font=('arial', 16), command=root.destroy)
    button3.grid(row=1, column=0,sticky=S, padx=13, pady=3)

    Label(root, text='Спроба', font=('arial', 16)).grid(row=1, column=0, sticky=N+W, padx=80, pady=5)

    EntryB = Entry(root, width=20, font='Arial 18')
    EntryB.grid(row=1, column=0, sticky=N, pady=35)

    new1 = PhotoImage(file="byk.png")
    label1 = Label(root, image=new1, height=150, width=150)
    label1.image = new1
    label1.grid(row=0, column=1, padx=15, sticky=N+E+W+S)

    new2 = PhotoImage(file="korova.png")
    label2 = Label(root, image=new2, height=150, width=150)
    label2.image = new2
    label2.grid(row=0, column=2, padx=15, sticky=N+E+W+S)

    listbox1 = Listbox(root, font=('arial', 16))
    listbox1.grid(row=1, column=1, columnspan=2, sticky=W+E, padx=10, pady=0)

    scrolly = Scrollbar(root, orient=VERTICAL)
    scrolly.grid(row=1, column=3, sticky=N+S)

    listbox1.config(yscrollcommand=scrolly.set)
    scrolly.config(command=listbox1.yview)
    

def perevirka2(EntryA, EntryB, listbox1, start_game):
    global st0, won
    
    st = EntryA.get()
    
    if won == True:
        return []

    listbox1.insert(END, st)

    if (len(st) != 4) or (not st.isdigit()) or (are_digits_unique(st) == False):
        listbox1.insert(END, 'Не коректно введене число(повинно бути 4 різні цифри)')
        return []
    
    value = check_default_value(st0)
    if len(value) != 4:
        st0 = start_game('')
    
    sproba(num, EntryB)
    #print(st0)         // можна розкоментувати, щоб в консолі бачити загадане число
       
    ls = list(st)
    ls0 = list(st0)
    
    bulls, cows = check_bulls_cows(st0, st)
    
    result = ['Биків:', str(bulls), 'Корів:', str(cows)]
    listbox1.insert(END, ' '.join(result))

    if st == st0:
        EntryB.insert(0, 'Ви вгадали! Спроб - ')
        won = True
    
    return result




