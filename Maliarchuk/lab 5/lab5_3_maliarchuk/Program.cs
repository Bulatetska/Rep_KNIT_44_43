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

    public string Title { get => _title; set => _title = value; }
    public string Author { get => _author; set => _author = value; }
    public decimal Price { get => _price; set => _price = value; }

    public virtual void Print()
    {
        Console.WriteLine($"Назва: {_title}, Автор: {_author}, Вартість: {_price}");
    }
}

class BookGenre : Book
{
    private string _genre;

    public BookGenre(string title, string author, decimal price, string genre)
        : base(title, author, price)
    {
        _genre = genre;
    }

    public string Genre { get => _genre; set => _genre = value; }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Жанр: {_genre}");
    }
}

sealed class BookGenrePubl : BookGenre
{
    private string _publisher;

    public BookGenrePubl(string title, string author, decimal price, string genre, string publisher)
        : base(title, author, price, genre)
    {
        _publisher = publisher;
    }

    public string Publisher { get => _publisher; set => _publisher = value; }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Видавець: {_publisher}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        var book = new Book("1984", "Джордж Орвелл", 150);
        book.Print();
        var bookGenre = new BookGenre("1984", "Джордж Орвелл", 150, "Фантастика");
        bookGenre.Print();
        var bookGenrePubl = new BookGenrePubl("1984", "Джордж Орвелл", 150, "Фантастика", "Видавництво XYZ");
        bookGenrePubl.Print();

    }
}
