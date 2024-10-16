using System;

// Клас Book
class Book
{
    public string Title { get; set; }           // Назва книги
    public string Author { get; set; }          // Автор книги
    public double Price { get; set; }           // Вартість книги

    // Конструктор з 3 параметрами
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Метод для виведення інформації про книгу
    public virtual void Print()
    {
        Console.WriteLine($"Назва: {Title}, Автор: {Author}, Вартість: {Price} грн");
    }
}

// Клас BookGenre, що успадковує Book і додає поле жанру
class BookGenre : Book
{
    public string Genre { get; set; }           // Жанр книги

    // Конструктор з 4 параметрами
    public BookGenre(string title, string author, double price, string genre)
        : base(title, author, price)            // Виклик конструктора базового класу
    {
        Genre = genre;
    }

    // Метод для виведення інформації, включаючи жанр
    public override void Print()
    {
        base.Print();                           // Виклик методу Print() базового класу
        Console.WriteLine($"Жанр: {Genre}");
    }
}

// Клас BookGenrePubl, що успадковує BookGenre і додає поле видавця
sealed class BookGenrePubl : BookGenre          // sealed означає, що клас не може бути успадкованим
{
    public string Publisher { get; set; }       // Видавець книги

    // Конструктор з 5 параметрами
    public BookGenrePubl(string title, string author, double price, string genre, string publisher)
        : base(title, author, price, genre)     // Виклик конструктора базового класу
    {
        Publisher = publisher;
    }

    // Метод для виведення інформації, включаючи видавця
    public override void Print()
    {
        base.Print();                           // Виклик методу Print() базового класу
        Console.WriteLine($"Видавець: {Publisher}");
    }
}

// Основна програма
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу BookGenrePubl
        BookGenrePubl book = new BookGenrePubl("Шлях королів", "Брендон Сандерсон", 450.00, "Фентезі", "Видавництво XYZ");

        // Виведення інформації про книгу
        book.Print();

        Console.WriteLine("\nНатисніть будь-яку клавішу, щоб завершити...");
        Console.ReadKey();
    }
}
