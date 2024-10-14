using System;

public class Person
{
    private string name;
    private int age;
    private string gender;
    private string phoneNumber;

    public void SetName(string name) => this.name = name;
    public void SetAge(int age) => this.age = age;
    public void SetGender(string gender) => this.gender = gender;
    public void SetPhoneNumber(string phoneNumber) => this.phoneNumber = phoneNumber;

    public void Print()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Gender: {gender}, Phone: {phoneNumber}");
    }
}

public class Student
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
        Console.WriteLine($"Surname: {surname}, Course: {course}, Record Book Number: {recordBookNumber}");
    }
}

public class Aspirant : Student
{
    public Aspirant(string surname, int course, string recordBookNumber)
        : base(surname, course, recordBookNumber) { }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("This is an Aspirant.");
    }
}

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string title, string author, decimal price)
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

    public decimal Price
    {
        get => price;
        set => price = value;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price:C}");
    }
}

public class BookGenre : Book
{
    private string genre;

    public BookGenre(string title, string author, decimal price, string genre)
        : base(title, author, price)
    {
        this.genre = genre;
    }

    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Genre: {genre}");
    }
}

public sealed class BookGenrePubl : BookGenre
{
    private string publisher;

    public BookGenrePubl(string title, string author, decimal price, string genre, string publisher)
        : base(title, author, price, genre)
    {
        this.publisher = publisher;
    }

    public string Publisher
    {
        get => publisher;
        set => publisher = value;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Publisher: {publisher}");
    }
}

public class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Figure: {name}");
    }
}

public class Rectangle : Figure
{
    private int x1, y1, x2, y2;

    public Rectangle(int x1, int y1, int x2, int y2)
        : base("Rectangle")
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public Rectangle() : this(0, 0, 1, 1) { }

    public new void Display()
    {
        base.Display();
        Console.WriteLine($"Coordinates: ({x1}, {y1}), ({x2}, {y2})");
    }

    public int Area()
    {
        return (x2 - x1) * (y2 - y1);
    }
}

public class RectangleColor : Rectangle
{
    private string color;

    public RectangleColor(int x1, int y1, int x2, int y2, string color)
        : base(x1, y1, x2, y2)
    {
        this.color = color;
    }

    public RectangleColor() : this(0, 0, 1, 1, "Default Color") { }

    public new void Display()
    {
        base.Display();
        Console.WriteLine($"Color: {color}");
    }

    public new int Area()
    {
        return base.Area();
    }
}

class Program
{
    static void Main()
    {
        // Task 1: Person class
        Person person = new Person();
        person.SetName("John Doe");
        person.SetAge(30);
        person.SetGender("Male");
        person.SetPhoneNumber("123-456-7890");
        person.Print();

        // Task 2: Student and Aspirant classes
        Student student = new Student("Smith", 2, "12345");
        student.Print();

        Aspirant aspirant = new Aspirant("Johnson", 3, "54321");
        aspirant.Print();

        // Task 3: Book, BookGenre, and BookGenrePubl classes
        Book book = new Book("C# Programming", "John Smith", 29.99m);
        book.Print();

        BookGenre bookGenre = new BookGenre("C# Programming", "John Smith", 29.99m, "Education");
        bookGenre.Print();

        BookGenrePubl bookGenrePubl = new BookGenrePubl("C# Programming", "John Smith", 29.99m, "Education", "Tech Books");
        bookGenrePubl.Print();

        // Task 4: Figure, Rectangle, and RectangleColor classes
        Figure figure = new Rectangle(0, 0, 5, 10);
        figure.Display();
        Rectangle rectangle = new Rectangle(0, 0, 5, 10);
        rectangle.Display();
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");

        RectangleColor rectangleColor = new RectangleColor(0, 0, 5, 10, "Red");
        rectangleColor.Display();
        Console.WriteLine($"RectangleColor Area: {rectangleColor.Area()}");
    }
}
