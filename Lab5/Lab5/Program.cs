using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
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
        private string lastName;
        private int course;
        private string studentId;

        public Student(string lastName, int course, string studentId)
        {
            this.lastName = lastName;
            this.course = course;
            this.studentId = studentId;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Course
        {
            get => course;
            set => course = value;
        }

        public string StudentId
        {
            get => studentId;
            set => studentId = value;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Last Name: {lastName}, Course: {course}, Student ID: {studentId}");
        }
    }

    public class Aspirant : Student
    {
        public Aspirant(string lastName, int course, string studentId)
            : base(lastName, course, studentId) { }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Aspirant");
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

        public virtual void Print()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
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

        public override void Print()
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

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Publisher: {publisher}");
        }
    }

    public class Figure
    {
        protected string name;

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

        public Rectangle(string name, int x1, int y1, int x2, int y2)
            : base(name)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public Rectangle() : this("Rectangle", 0, 0, 1, 1) { }

        public virtual void Display()
        {
            base.Display();
            Console.WriteLine($"Coordinates: ({x1}, {y1}), ({x2}, {y2})");
        }

        public int Area()
        {
            return Math.Abs((x2 - x1) * (y2 - y1));
        }
    }

    public class RectangleColor : Rectangle
    {
        private string color;

        public RectangleColor(string name, int x1, int y1, int x2, int y2, string color)
            : base(name, x1, y1, x2, y2)
        {
            this.color = color;
        }

        public RectangleColor() : this("Colored Rectangle", 0, 0, 1, 1, "Red") { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Color: {color}");
        }

        public new int Area()
        {
            return base.Area();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure;

            Rectangle rectangle = new Rectangle("My Rectangle", 2, 3, 8, 12);
            figure = rectangle;
            figure.Display();
            Console.WriteLine($"Area: {rectangle.Area()}");

            RectangleColor rectangleColor = new RectangleColor("My Colorful Rectangle", 1, 1, 6, 9, "Green");
            figure = rectangleColor;
            figure.Display();
            Console.WriteLine($"Area: {rectangleColor.Area()}");

            Person person = new Person();
            person.SetName("Alice Wonderland");
            person.SetAge(25);
            person.SetGender("Female");
            person.SetPhoneNumber("555-0123");
            person.Print();

            Student student = new Student("Doe", 2, "S98765");
            student.Print();

            Aspirant aspirant = new Aspirant("Smithson", 1, "A54321");
            aspirant.Print();

            Book book = new Book("Learning Python", "Emily Davis", 35.50m);
            book.Print();

            BookGenre bookGenre = new BookGenre("Learning Python", "Emily Davis", 35.50m, "Programming");
            bookGenre.Print();

            BookGenrePubl bookGenrePubl = new BookGenrePubl("Learning Python", "Emily Davis", 35.50m, "Programming", "Code Press");
            bookGenrePubl.Print();
        }
    }
}
