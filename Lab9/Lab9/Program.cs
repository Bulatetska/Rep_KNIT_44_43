using System;

namespace Lab9
{
    // Class 1: Person
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}, Phone: {PhoneNumber}");
        }
    }

    // Class 2: Student and Aspirant
    public class Student
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
            Console.WriteLine($"LastName: {LastName}, Course: {Course}, Record Book Number: {RecordBookNumber}");
        }
    }

    public class Aspirant : Student
    {
        public Aspirant(string lastName, int course, string recordBookNumber)
            : base(lastName, course, recordBookNumber)
        {
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Status: Aspirant");
        }
    }

    // Class 3: Book, BookGenre, BookGenrePubl
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

    // Class 4: Figure, Rectangle, RectangleColor
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

        public RectangleColor() : this(0, 0, 1, 1, "Transparent") { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Color: {Color}");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Rectangle();
            Figure coloredFigure = new RectangleColor();

            figure.Display();
            Console.WriteLine($"Area: {(figure as Rectangle).Area()}");

            coloredFigure.Display();
            Console.WriteLine($"Area: {(coloredFigure as RectangleColor).Area()}");
        }
    }
}
