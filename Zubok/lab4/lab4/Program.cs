using System;

// Завдання 1: Клас Person
class Person
{
    private string name;
    private int age;
    private string gender;
    private string phoneNumber;

    public Person(string name, int age, string gender, string phoneNumber)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.phoneNumber = phoneNumber;
    }

    public void SetName(string name) => this.name = name;
    public void SetAge(int age) => this.age = age;
    public void SetGender(string gender) => this.gender = gender;
    public void SetPhoneNumber(string phoneNumber) => this.phoneNumber = phoneNumber;

    public void Print()
    {
        Console.WriteLine($"Ім'я: {name}, Вік: {age}, Стать: {gender}, Телефон: {phoneNumber}");
    }
}

// Завдання 2: Клас Student та Aspirant
class Student
{
    private string surname;
    private int course;
    private string recordBookNumber;

    public Student(string surname, int course, string recordBookNumber)
    {
        this.surname = surname;
        this.course = course;
        this.recordBookNumber = recordBookNumber;
    }

    public string Surname
    {
        get => surname;
        set => surname = value;
    }

    public int Course
    {
        get => course;
        set => course = value;
    }

    public string RecordBookNumber
    {
        get => recordBookNumber;
        set => recordBookNumber = value;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Прізвище: {surname}, Курс: {course}, Номер залікової книжки: {recordBookNumber}");
    }
}

class Aspirant : Student
{
    public Aspirant(string surname, int course, string recordBookNumber)
        : base(surname, course, recordBookNumber) { }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Аспірант: Так");
    }
}

// Завдання 3: Клас Book, BookGenre та BookGenrePubl
class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Author
    {
        get => author;
        set => author = value;
    }

    public double Price
    {
        get => price;
        set => price = value;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Назва книги: {title}, Автор: {author}, Вартість: {price}");
    }
}

class BookGenre : Book
{
    private string genre;

    public BookGenre(string title, string author, double price, string genre)
        : base(title, author, price)
    {
        this.genre = genre;
    }

    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Жанр: {genre}");
    }
}

sealed class BookGenrePubl : BookGenre
{
    private string publisher;

    public BookGenrePubl(string title, string author, double price, string genre, string publisher)
        : base(title, author, price, genre)
    {
        this.publisher = publisher;
    }

    public string Publisher
    {
        get => publisher;
        set => publisher = value;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Видавець: {publisher}");
    }
}

// Завдання 4: Клас Figure, Rectangle та RectangleColor
class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Назва фігури: {name}");
    }
}

class Rectangle : Figure
{
    private int x1, y1, x2, y2;

    public Rectangle(string name, int x1, int y1, int x2, int y2)
        : base(name)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public Rectangle() : this("Прямокутник", 0, 0, 1, 1) { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Координати: ({x1}, {y1}), ({x2}, {y2})");
    }

    public double Area()
    {
        return Math.Abs((x2 - x1) * (y2 - y1));
    }
}

class RectangleColor : Rectangle
{
    private string color;

    public RectangleColor(string name, int x1, int y1, int x2, int y2, string color)
        : base(name, x1, y1, x2, y2)
    {
        this.color = color;
    }

    public RectangleColor() : this("Прямокутник", 0, 0, 1, 1, "Без кольору") { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Колір: {color}");
    }

    public new double Area()
    {
        return base.Area();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1: Перевірка класу Person
        Console.WriteLine("Завдання 1: Клас Person");
        Person person = new Person("Іван", 32, "Чоловік", "0973457865");
        person.Print();
        Console.WriteLine();

        // Завдання 2: Перевірка класів Student та Aspirant
        Console.WriteLine("Завдання 2: Клас Student та Aspirant");
        Student student = new Student("Петренко", 3, "123456");
        student.Print();
        Console.WriteLine();

        Aspirant aspirant = new Aspirant("Шевченко", 4, "654321");
        aspirant.Print();
        Console.WriteLine();

        // Завдання 3: Перевірка класів Book, BookGenre та BookGenrePubl
        Console.WriteLine("Завдання 3: Клас Book, BookGenre та BookGenrePubl");
        Book book = new Book("Дев'ятий Дім", "Лі Бардуґо", 430);
        book.Print();
        Console.WriteLine();

        BookGenre bookGenre = new BookGenre("Дев'ятий Дім", "Лі Бардуґо", 430, "Фантастика");
        bookGenre.Print();
        Console.WriteLine();

        BookGenrePubl bookGenrePubl = new BookGenrePubl("Дев'ятий Дім", "Лі Бардуґо", 430, "Фантастика", "Vivat");
        bookGenrePubl.Print();
        Console.WriteLine();

        // Завдання 4: Перевірка класів Figure, Rectangle та RectangleColor
        Console.WriteLine("Завдання 4: Клас Figure, Rectangle та RectangleColor");
        Figure figure;

        figure = new Rectangle("Прямокутник", 0, 0, 5, 3);
        Console.WriteLine("Дані про фігуру:");
        figure.Display();
        Console.WriteLine($"Площа: {((Rectangle)figure).Area()}");

        Console.WriteLine();

        figure = new RectangleColor("Прямокутник", 1, 1, 4, 4, "Зелений");
        Console.WriteLine("Дані про фігуру:");
        figure.Display();
        Console.WriteLine($"Площа: {((RectangleColor)figure).Area()}");
    }
}
