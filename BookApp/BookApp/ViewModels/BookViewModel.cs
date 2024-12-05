using BookApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookApp.ViewModels
{
    public class BookViewModel
    {
        public ObservableCollection<Book> Books { get; set; }
        public Book SelectedBook { get; set; }

        public ICommand AddBookCommand { get; set; }
        public ICommand DeleteBookCommand { get; set; }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            AddBookCommand = new RelayCommand(AddBook);
            DeleteBookCommand = new RelayCommand(DeleteBook);
        }

        private void AddBook()
        {
            if (SelectedBook != null)
            {
                Books.Add(new Book
                {
                    Title = SelectedBook.Title,
                    Author = SelectedBook.Author,
                    Year = SelectedBook.Year
                });

                // Clear the input fields after adding
                SelectedBook = null;
            }
        }

        private void DeleteBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
                SelectedBook = null;
            }
        }
    }
}
