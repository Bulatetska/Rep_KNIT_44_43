from tkinter import *

def create_gui(root, start_game):
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

    new1 = PhotoImage(file="byk1.png")
    label1 = Label(root, image=new1, height=150, width=150)
    label1.grid(row=0, column=1, padx=15, sticky=N+E+W+S)

    new2 = PhotoImage(file="korova1.png")
    label2 = Label(root, image=new2, height=150, width=150)
    label2.grid(row=0, column=2, padx=15, sticky=N+E+W+S)

    listbox1 = Listbox(root, font=('arial', 16))
    listbox1.grid(row=1, column=1, columnspan=2, sticky=W+E, padx=10, pady=0)

    scrolly = Scrollbar(root, orient=VERTICAL)
    scrolly.grid(row=1, column=3, sticky=N+S)

    listbox1.config(yscrollcommand=scrolly.set)
    scrolly.config(command=listbox1.yview)

def perevirka2(EntryA, EntryB, listbox1, start_game):
    st = EntryA.get()

    if (len(st) != 4) or (not(st.isdigit())):
        listbox1.insert(END,'повинно бути 4 цифри ')
        return

    num, st0 = start_game()
    sproba(num)
    
    ls = list(st)
    ls0 = list(st0)
    
    bulls = 0
    for j in range(4):
        if ls[j] == ls0[j]:
            bulls += 1
   
    cows = 0
    for j in range(4):
        n = ls[j]
        for k in range(4):
            if n == ls0[k]:
                cows += 1
    listbox1.insert(END, 'Биків:', bulls, ' Коров:', cows-bulls)

    if st == st0:
        EntryB.insert(0, 'Ви вгадали! Спроб - ')


