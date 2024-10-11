using System;

// Клас Person, без змін
class Person
{
    private string name;
    private int age;
    private string gender;
    private string phoneNumber;

    // Метод для зміни імені
    public void SetName(string newName) => name = newName;

    // Метод для отримання імені
    public string GetName() => name;

    // Метод для зміни віку
    public void SetAge(int newAge) => age = newAge;

    // Метод для отримання віку
    public int GetAge() => age;

    // Метод для зміни статі
    public void SetGender(string newGender) => gender = newGender;

    // Метод для отримання статі
    public string GetGender() => gender;

    // Метод для зміни телефонного номера
    public void SetPhoneNumber(string newPhoneNumber) => phoneNumber = newPhoneNumber;

    // Метод для отримання телефонного номера
    public string GetPhoneNumber() => phoneNumber;

    // Метод Print(), який виводить інформацію про людину
    public void Print() => Console.WriteLine($"Name: {name}, Age: {age}, Gender: {gender}, Phone: {phoneNumber}");
}

// Базовий клас Student
class Student
{
    public string LastName { get; set; }
    public int Course { get; set; }
    public string RecordBookNumber { get; set; }

    // Конструктор із параметрами
    public Student(string lastName, int course, string recordBookNumber)
    {
        LastName = lastName;
        Course = course;
        RecordBookNumber = recordBookNumber;
    }

    // Метод Print()
    public virtual void Print() => Console.WriteLine($"Student: {LastName}, Course: {Course}, RecordBook: {RecordBookNumber}");
}

// Похідний клас Aspirant
class Aspirant : Student
{
    public string ResearchTopic { get; set; } // Додаткове поле для аспіранта

    // Конструктор із використанням base і додатковим параметром ResearchTopic
    public Aspirant(string lastName, int course, string recordBookNumber, string researchTopic)
        : base(lastName, course, recordBookNumber)
    {
        ResearchTopic = researchTopic;
    }

    // метод Print()
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Research Topic: {ResearchTopic}");
    }
}

// Клас Book
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Конструктор із 3 параметрами
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Метод Print()
    public virtual void Print() => Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
}

// Похідний клас BookGenre
class BookGenre : Book
{
    public string Genre { get; set; }

    // Конструктор із 4 параметрами
    public BookGenre(string title, string author, double price, string genre)
        : base(title, author, price)
    {
        Genre = genre;
    }

    // Перевизначений метод Print()
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Genre: {Genre}");
    }
}

// Похідний клас BookGenrePubl (sealed - остаточний клас)
sealed class BookGenrePubl : BookGenre
{
    public string Publisher { get; set; }

    // Конструктор із 5 параметрами
    public BookGenrePubl(string title, string author, double price, string genre, string publisher)
        : base(title, author, price, genre)
    {
        Publisher = publisher;
    }

    // Перевизначений метод Print()
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Publisher: {Publisher}");
    }
}

// Клас Figure
class Figure
{
    public string Name { get; set; }

    public Figure(string name) => Name = name;

    public virtual void Display() => Console.WriteLine($"Figure: {Name}");
}

// Похідний клас Rectangle
class Rectangle : Figure
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    // Конструктор із 5 параметрами
    public Rectangle(string name, int x1, int y1, int x2, int y2)
        : base(name)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public Rectangle() : this("Rectangle", 0, 0, 1, 1) { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Coordinates: ({X1}, {Y1}), ({X2}, {Y2})");
    }

    public int Area() => Math.Abs((X2 - X1) * (Y2 - Y1));
}

// Похідний клас RectangleColor
class RectangleColor : Rectangle
{
    public string Color { get; set; }

    public RectangleColor(string name, int x1, int y1, int x2, int y2, string color)
        : base(name, x1, y1, x2, y2) => Color = color;

    public RectangleColor() : this("Colored Rectangle", 0, 0, 1, 1, "red") { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Color: {Color}");
    }

    public new int Area() => base.Area();
}

// Точка входу
class Program
{
   static void Main(string[] args)
    {
        // Створення та виведення інформації про студента
    Student student = new Student("Smith", 3, "12345");
    student.Print();

    // Створення та виведення інформації про аспіранта
    Aspirant aspirant = new Aspirant("Johnson", 4, "67890", "Machine Learning in Image Processing");
    aspirant.Print();
        // Оголосити посилання на базовий клас Figure
        Figure figure;

        // Створити екземпляр класу Rectangle з координатами за замовчуванням (0, 0) та (1, 1)
        figure = new Rectangle(); // Використовується конструктор без параметрів
        
        // Виклик методу Display() для класу Rectangle через посилання на Figure
        figure.Display(); // Виведе: Coordinates: (0, 0), (1, 1)

        // Створити екземпляр класу RectangleColor
        figure = new RectangleColor("ColoredRectangle1", 2, 3, 7, 8, "blue");
        figure.Display(); // Виведе координати (2, 3), (7, 8)

        // Використання типізації для доступу до Area()
        RectangleColor coloredRectangle = (RectangleColor)figure;
        Console.WriteLine($"Area: {coloredRectangle.Area()}");
    }
}
