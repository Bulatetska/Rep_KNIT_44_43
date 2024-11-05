using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int Price { get; set; }

        public Book(string title, string authorFirstName, string authorLastName, int price)
        {
            this.Title = title;
            this.AuthorFirstName = authorFirstName;
            this.AuthorLastName = authorLastName;
            this.Price = price;
        }

        public virtual void Print ()
        {
            Console.WriteLine("Book " + this.Title + " from " + this.AuthorFirstName + " " + this.AuthorLastName + " cost " + this.Price) ;
        }
    }

    public class BookGenre : Book
    {
        public string Genre { get; set; }

        public BookGenre(string title, string authorFirstName, string authorLastName, int price, string genre) : base(title, authorFirstName, authorLastName, price)
        {
            this.Genre = genre;
        }

        public override void Print()
        {
            base.Print();

            Console.WriteLine("This book is " + this.Genre + " genre");
        }
    }

    public sealed class BookGenrePubl : BookGenre
    {
        public string Publisher { get; set; }
        public BookGenrePubl(string title, string authorFirstName, string authorLastName, int price, string genre, string publisher) : base(title, authorFirstName, authorLastName, price, genre)
        {
            this.Publisher = publisher;
        }

        public override void Print()
        {
            base.Print(); Console.WriteLine("Publisher of this book: " + this.Publisher);
        }

    }
}
