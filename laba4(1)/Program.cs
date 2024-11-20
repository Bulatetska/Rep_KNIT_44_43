using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    // Поля для зберігання даних про особу
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }

    public void Print()
    {
        // Вивід інформації про людину
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Phone: {PhoneNumber}\n");
    }
}

class Student
{
    public string LastName { get; set; }
    public int Course { get; set; }
    public string RecordBookNumber { get; set; }

    public Student(string lastName, int course, string recordBookNumber)
    {
        LastName = lastName;
        Course = course;
        RecordBookNumber = recordBookNumber;
    }

    public virtual void Print()
    {
        // Вивід інформації про студента
        Console.WriteLine($"\nLastName: {LastName}, Course: {Course}, RecordBookNumber: {RecordBookNumber}\n");
    }
}

class Aspirant : Student
{
    public Aspirant(string lastName, int course, string recordBookNumber)
        : base(lastName, course, recordBookNumber) { }

    public override void Print()
    {
        // Виклик методу базового класу
        base.Print();//base дозволяє класу-нащадку використовувати вже наявні конструктори та методи з базового класу
        Console.WriteLine("Статус аспіранта: Готується до дисертації\n");
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public virtual void Print()
    {
        Console.WriteLine($"\nTitle: {Title}, Author: {Author}, Price: {Price}\n");
    }
}

class BookGenre : Book
{
    public string Genre { get; set; }

    public BookGenre(string title, string author, decimal price, string genre)
        : base(title, author, price)
    {
        Genre = genre;
    }

    public override void Print()
    {
        // Виклик методу Print() базового класу
        base.Print();
        Console.WriteLine($"Genre: {Genre}");
    }
}

sealed class BookGenrePubl : BookGenre
{
    public string Publisher { get; set; }

    public BookGenrePubl(string title, string author, decimal price, string genre, string publisher)
        : base(title, author, price, genre)
    {
        Publisher = publisher;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Publisher: {Publisher}");
    }
}

class Figure
{
    public string Name { get; set; }

    public Figure(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"\nFigure: {Name}\n");
    }
}

class Rectangle : Figure
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Rectangle(int x1, int y1, int x2, int y2) : base("Rectangle")
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public Rectangle() : this(0, 0, 1, 1) { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Coordinates: ({X1},{Y1}) to ({X2},{Y2})");
    }

    public int Area()
    {
        return Math.Abs(X2 - X1) * Math.Abs(Y2 - Y1);
    }
}

class RectangleColor : Rectangle
{
    public string Color { get; set; }

    public RectangleColor(int x1, int y1, int x2, int y2, string color) : base(x1, y1, x2, y2)
    {
        Color = color;
    }

    public RectangleColor() : this(0, 0, 1, 1, "Blue") { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Color: {Color}");
    }

    public new int Area()
    {
        return base.Area();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //  робота з класом Person
        Person person = new Person { Name = "Діана", Age = 20, Gender = "Дівчина", PhoneNumber = "123-456-789" };
        person.Print();

        //  робота з класами Student та Aspirant
        Student student = new Student("Вітковець", 3, "123456");
        student.Print();

        Console.WriteLine("Аспірант:");
        Aspirant aspirant = new Aspirant("Зубок", 4, "654321");
        aspirant.Print();

        // Приклад роботи з класами Book, BookGenre, BookGenrePubl
        Book book = new Book("9 листопада ", "Колін Гувер", 250);
        book.Print();

        BookGenre bookGenre = new BookGenre("Гаррі Поттер і таємна кімната", "Джоан Роулінг", 330, "Фантастика");
        bookGenre.Print();

        BookGenrePubl bookGenrePubl = new BookGenrePubl("Бунгало", "Сара Джіо", 400, "Романтика", "КСД");
        bookGenrePubl.Print();

        // Приклад роботи з класами Figure, Rectangle, RectangleColor
       
        Rectangle rectangle = new Rectangle(2, 3, 6, 9);
        rectangle.Display();
        Console.WriteLine("Площа прямокутника: " + rectangle.Area());

        RectangleColor rectangleColor = new RectangleColor(0, 6, 3, 4, "Зелений");
        rectangleColor.Display();
        Console.WriteLine("Площа кольорового прямокутника: " + rectangleColor.Area());
    }
}
