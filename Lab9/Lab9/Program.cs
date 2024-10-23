using System;
using System.Globalization;
using NUnit.Framework;

namespace Lab9
{
    // Base class for person information
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

        public string GetDetails() => $"Name: {name}, Age: {age}, Gender: {gender}, Phone: {phoneNumber}";
    }

    // Base class for student information
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

        public virtual string Print() => $"Last Name: {lastName}, Course: {course}, Student ID: {studentId}";
    }

    // Derived class for aspirant (graduate student)
    public class Aspirant : Student
    {
        public Aspirant(string lastName, int course, string studentId)
            : base(lastName, course, studentId) { }

        public override string Print() => base.Print() + "\nAspirant";
    }

    // Base class for book information
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

        public virtual string Print() => $"Title: {title}, Author: {author}, Price: {price.ToString("0.00", CultureInfo.InvariantCulture)}";
    }

    // Derived class for book with genre
    public class BookGenre : Book
    {
        private string genre;

        public BookGenre(string title, string author, decimal price, string genre)
            : base(title, author, price)
        {
            this.genre = genre;
        }

        public override string Print() => base.Print() + $"\nGenre: {genre}";
    }

    // Derived class for book with genre and publisher
    public sealed class BookGenrePubl : BookGenre
    {
        private string publisher;

        public BookGenrePubl(string title, string author, decimal price, string genre, string publisher)
            : base(title, author, price, genre)
        {
            this.publisher = publisher;
        }

        public override string Print() => base.Print() + $"\nPublisher: {publisher}";
    }

    // Base class for geometric figures
    public class Figure
    {
        protected string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public virtual string Display() => $"Figure: {name}";
    }

    // Derived class for rectangle
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

        public override string Display()
        {
            return base.Display() + $"\nCoordinates: ({x1}, {y1}), ({x2}, {y2})";
        }

        public int Area() => Math.Abs((x2 - x1) * (y2 - y1));
    }

    // Derived class for colored rectangle
    public class RectangleColor : Rectangle
    {
        private string color;

        public RectangleColor(string name, int x1, int y1, int x2, int y2, string color)
            : base(name, x1, y1, x2, y2)
        {
            this.color = color;
        }

        public override string Display() => base.Display() + $"\nColor: {color}";
    }

    [TestFixture]
    public class LabTests
    {
        [Test]
        public void Person_SetGetName_ShouldReturnCorrectDetails()
        {
            var person = new Person();
            person.SetName("Alice Wonderland");
            person.SetAge(25);
            person.SetGender("Female");
            person.SetPhoneNumber("555-0123");

            var details = person.GetDetails();
            // Assert
            Assert.That(details, Is.EqualTo("Name: Alice Wonderland, Age: 25, Gender: Female, Phone: 555-0123"));
        }

        [Test]
        public void Student_Print_ShouldReturnCorrectInfo()
        {
            var student = new Student("Doe", 2, "S98765");

            var result = student.Print();

            Assert.That(result, Is.EqualTo("Last Name: Doe, Course: 2, Student ID: S98765"));
        }

        [Test]
        public void Aspirant_Print_ShouldReturnCorrectInfo()
        {
            var aspirant = new Aspirant("Smithson", 1, "A54321");

            var result = aspirant.Print();

            Assert.That(result, Is.EqualTo("Last Name: Smithson, Course: 1, Student ID: A54321\nAspirant"));
        }

        [Test]
        public void Book_Print_ShouldReturnCorrectInfo()
        {
            var book = new Book("Learning Python", "Emily Davis", 35.50m);

            var result = book.Print();
            
            Assert.That(result, Is.EqualTo("Title: Learning Python, Author: Emily Davis, Price: 35.50"));
        }

        [Test]
        public void BookGenre_Print_ShouldReturnCorrectInfo()
        {
            var bookGenre = new BookGenre("Learning Python", "Emily Davis", 35.50m, "Programming");

            var result = bookGenre.Print();

            Assert.That(result, Is.EqualTo("Title: Learning Python, Author: Emily Davis, Price: 35.50\nGenre: Programming"));
        }

        [Test]
        public void BookGenrePubl_Print_ShouldReturnCorrectInfo()
        {
            var bookGenrePubl = new BookGenrePubl("Learning Python", "Emily Davis", 35.50m, "Programming", "Code Press");

            var result = bookGenrePubl.Print();

            Assert.That(result, Is.EqualTo("Title: Learning Python, Author: Emily Davis, Price: 35.50\nGenre: Programming\nPublisher: Code Press"));
        }

        [Test]
        public void Rectangle_Area_ShouldReturnCorrectArea()
        {
            var rectangle = new Rectangle("My Rectangle", 2, 3, 8, 12);

            var area = rectangle.Area();
            
            Assert.That(area, Is.EqualTo(54));
        }

        [Test]
        public void Rectangle_Display_ShouldReturnCorrectDetails()
        {
            var rectangle = new Rectangle("My Rectangle", 2, 3, 8, 12);

            var display = rectangle.Display();

            Assert.That(display, Is.EqualTo("Figure: My Rectangle\nCoordinates: (2, 3), (8, 12)"));
        }

        [Test]
        public void RectangleColor_Display_ShouldReturnCorrectDetails()
        {
            var rectangleColor = new RectangleColor("My Colorful Rectangle", 1, 1, 6, 9, "Green");

            var display = rectangleColor.Display();

            Assert.That(display, Is.EqualTo("Figure: My Colorful Rectangle\nCoordinates: (1, 1), (6, 9)\nColor: Green"));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}