using System;

namespace TaskClasses
{
    // Завдання 1
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public void Print()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}, Стать: {Gender}, Телефон: {PhoneNumber}");
        }
    }

    // Завдання 2
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
            Console.WriteLine($"Студент: {LastName}, Курс: {Course}, Номер залікової: {RecordBookNumber}");
        }
    }

    class Aspirant : Student
    {
        public Aspirant(string lastName, int course, string recordBookNumber)
            : base(lastName, course, recordBookNumber) { }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Аспірант готується до захисту кандидатської дисертації.");
        }
    }

    // Завдання 3
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Назва: {Title}, Автор: {Author}, Вартість: {Price} грн");
        }
    }

    class BookGenre : Book
    {
        public string Genre { get; set; }

        public BookGenre(string title, string author, double price, string genre)
            : base(title, author, price)
        {
            Genre = genre;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Жанр: {Genre}");
        }
    }

    sealed class BookGenrePubl : BookGenre
    {
        public string Publisher { get; set; }

        public BookGenrePubl(string title, string author, double price, string genre, string publisher)
            : base(title, author, price, genre)
        {
            Publisher = publisher;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Видавництво: {Publisher}");
        }
    }

    // Завдання 4
    class Figure
    {
        public string Name { get; }

        public Figure(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Назва фігури: {Name}");
        }
    }

    class Rectangle : Figure
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Rectangle(string name, int x1, int y1, int x2, int y2) : base(name)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Rectangle() : this("Прямокутник", 0, 0, 1, 1) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Координати: ({X1}; {Y1}), ({X2}; {Y2})");
        }

        public virtual double Area()
        {
            return Math.Abs((X2 - X1) * (Y2 - Y1));
        }
    }

    class RectangleColor : Rectangle
    {
        public string Color { get; set; }

        public RectangleColor(string name, int x1, int y1, int x2, int y2, string color)
            : base(name, x1, y1, x2, y2)
        {
            Color = color;
        }

        public RectangleColor() : this("Кольоровий прямокутник", 0, 0, 1, 1, "Червоний") { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Колір: {Color}");
        }

        public override double Area()
        {
            return base.Area();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            Person person = new Person
            {
                Name = "Іван",
                Age = 25,
                Gender = "Чоловік",
                PhoneNumber = "+380123456789"
            };
            person.Print();

            Console.WriteLine();

            // Завдання 2
            Student student = new Student("Петренко", 3, "12345");
            student.Print();

            Aspirant aspirant = new Aspirant("Іванов", 4, "67890");
            aspirant.Print();

            Console.WriteLine();

            // Завдання 3
            Book book = new Book("Кобзар", "Тарас Шевченко", 250);
            book.Print();

            BookGenre bookGenre = new BookGenre("Кобзар", "Тарас Шевченко", 250, "Поезія");
            bookGenre.Print();

            BookGenrePubl bookPubl = new BookGenrePubl("Кобзар", "Тарас Шевченко", 250, "Поезія", "А-БА-БА-ГА-ЛА-МА-ГА");
            bookPubl.Print();

            Console.WriteLine();

            // Завдання 4
            Figure figure = new Figure("Фігура");
            figure.Display();

            Rectangle rectangle = new Rectangle("Прямокутник", 0, 0, 4, 3);
            rectangle.Display();
            Console.WriteLine($"Площа: {rectangle.Area()}");

            RectangleColor rectangleColor = new RectangleColor("Кольоровий прямокутник", 0, 0, 4, 3, "Синій");
            rectangleColor.Display();
            Console.WriteLine($"Площа: {rectangleColor.Area()}");

            // Використання посилання на базовий клас
            Figure figRef = rectangleColor;
            figRef.Display();
        }
    }
}
