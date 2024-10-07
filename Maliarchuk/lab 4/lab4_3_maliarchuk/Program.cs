using System;

class Book
{
    private string _title;
    private string _author;
    private decimal _price;

    public Book(string title, string author, decimal price)
    {
        _title = title;
        _author = author;
        _price = price;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public virtual void Print()
    {
        Console.WriteLine($"Назва: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Вартість: {Price:C}"); // Форматування валюти
    }
}

class BookGenre : Book
{
    private string _genre;

    public BookGenre(string title, string author, decimal price, string genre)
        : base(title, author, price) // Виклик конструктора базового класу
    {
        _genre = genre;
    }

    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }

    public override void Print()
    {
        base.Print(); 
        Console.WriteLine($"Жанр: {Genre}");
    }
}

class BookGenrePubl : BookGenre
{
    private string _publisher;

    public BookGenrePubl(string title, string author, decimal price, string genre, string publisher)
        : base(title, author, price, genre) 
    {
        _publisher = publisher;
    }

    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }

    public override void Print()
    {
        base.Print(); 
        Console.WriteLine($"Видавець: {Publisher}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Heaven Official's Blessing", "MXTX", 20);
        Console.WriteLine("Інформація про книгу:");
        book.Print();

        BookGenre bookGenre = new BookGenre("Alice's Adventures in Wonderland", "Lewis Carroll", 8, "Повість-казка");
        Console.WriteLine("\nІнформація про книгу з жанром:");
        bookGenre.Print();

        BookGenrePubl bookGenrePubl = new BookGenrePubl("The Little Prince", "Antoine de Saint-Exupéry", 10, "Казка-роман", "Ранок");
        Console.WriteLine("\nІнформація про книгу з жанром і видавцем:");
        bookGenrePubl.Print();
    }
}
