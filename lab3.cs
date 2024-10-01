using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }

    // Метод для зміни даних
    public void ChangeName(string newName)
    {
        Name = newName;
    }

    public void ChangeAge(int newAge)
    {
        Age = newAge;
    }

    public void ChangeGender(string newGender)
    {
        Gender = newGender;
    }

    public void ChangePhoneNumber(string newPhoneNumber)
    {
        PhoneNumber = newPhoneNumber;
    }

    // Метод для виведення інформації
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Phone: {PhoneNumber}");
    }
}

public class Student
{
    public string Surname { get; set; }
    public int Course { get; set; }
    public string RecordBookNumber { get; set; }

    public Student(string surname, int course, string recordBookNumber)
    {
        Surname = surname;
        Course = course;
        RecordBookNumber = recordBookNumber;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Surname: {Surname}, Course: {Course}, Record Book Number: {RecordBookNumber}");
    }
}

public class Aspirant : Student
{
    public string ThesisTopic { get; set; }

    public Aspirant(string surname, int course, string recordBookNumber, string thesisTopic)
        : base(surname, course, recordBookNumber)
    {
        ThesisTopic = thesisTopic;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Thesis Topic: {ThesisTopic}");
    }
}

public class Book
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

public class BookGenre : Book
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

public sealed class BookGenrePubl : BookGenre
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

public class Figure
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

public class Rectangle : Figure
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Rectangle(int x1, int y1, int x2, int y2)
        : base("Rectangle")
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

    public virtual double Area()
    {
        return Math.Abs((X2 - X1) * (Y2 - Y1));
    }
}

public class RectangleColor : Rectangle
{
    public string Color { get; set; }

    public RectangleColor(int x1, int y1, int x2, int y2, string color)
        : base(x1, y1, x2, y2)
    {
        Color = color;
    }

    public RectangleColor() : this(0, 0, 1, 1, "Black") { }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Color: {Color}");
    }

    public override double Area()
    {
        return base.Area();
    }
}

// Основна функція Main
public static class Program
{
    public static void Main()
    {
        // 1. Person
        Person person = new Person { Name = "John Doe", Age = 30, Gender = "Male", PhoneNumber = "123-456-7890" };
        person.Print();

        // 2. Student і Aspirant
        Student student = new Student("Smith", 2, "12345");
        student.Print();

        Aspirant aspirant = new Aspirant("Johnson", 3, "67890", "Artificial Intelligence");
        aspirant.Print();

        // 3. Book, BookGenre, BookGenrePubl
        BookGenrePubl book = new BookGenrePubl("C# Programming", "Jane Doe", 29.99m, "Education", "TechBooks Publishing");
        book.Print();

        // 4. Figure, Rectangle, RectangleColor
        Figure figure = new Rectangle(2, 3, 5, 6);
        figure.Display();

        RectangleColor coloredRectangle = new RectangleColor(2, 3, 5, 6, "Red");
        coloredRectangle.Display();
        Console.WriteLine($"Area: {coloredRectangle.Area()}");
    }
}
