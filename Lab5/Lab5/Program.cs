using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Phone Number: {PhoneNumber}");
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
        Console.WriteLine($"Last Name: {LastName}, Course: {Course}, Record Book Number: {RecordBookNumber}");
    }
}

class Aspirant : Student
{
    public Aspirant(string lastName, int course, string recordBookNumber)
        : base(lastName, course, recordBookNumber) { }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Status: Aspirant");
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
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
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
        Console.WriteLine($"Figure: {Name}");
    }
}

class Rectangle : Figure
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Rectangle(int x1, int y1, int x2, int y2, string name = "Rectangle")
        : base(name)
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
        Console.WriteLine($"Coordinates: ({X1}, {Y1}), ({X2}, {Y2})");
    }

    public virtual int Area()
    {
        return Math.Abs(X2 - X1) * Math.Abs(Y2 - Y1);
    }
}

class RectangleColor : Rectangle
{
    public string Color { get; set; }

    public RectangleColor(int x1, int y1, int x2, int y2, string color, string name = "RectangleColor")
        : base(x1, y1, x2, y2, name)
    {
        Color = color;
    }

    public RectangleColor() : this(0, 0, 1, 1, "Black") { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Color: {Color}");
    }

    public override int Area()
    {
        return base.Area();
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "Володимир", Age = 21, Gender = "Male", PhoneNumber = "380-456-7890" };
        person.Print();

        Student student = new Student("Бодя", 2, "RB123");
        student.Print();

        Aspirant aspirant = new Aspirant("Ваня", 3, "RB456");
        aspirant.Print();

        Book book = new Book("Кобзар", "Тарас Шевченко", 15.99m);
        book.Print();

        BookGenre bookGenre = new BookGenre("Лис Микита", "Іван Франко", 15.99m, "Fiction");
        bookGenre.Print();

        BookGenrePubl bookGenrePubl = new BookGenrePubl("Ромео і Джульєта", "Вільям Шекспір", 15.99m, "Fiction", "Шекспір");
        bookGenrePubl.Print();

        Figure figureRef;

        Rectangle rectangle = new Rectangle(0, 0, 3, 4);
        figureRef = rectangle;
        figureRef.Display();
        Console.WriteLine($"Area: {rectangle.Area()}");

        RectangleColor rectangleColor = new RectangleColor(0, 0, 3, 4, "Червоний");
        figureRef = rectangleColor;
        figureRef.Display();
        Console.WriteLine($"Area: {rectangleColor.Area()}");
    }
}
