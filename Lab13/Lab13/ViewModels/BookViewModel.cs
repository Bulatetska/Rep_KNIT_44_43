using Lab13.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;


namespace Lab13.ViewModels
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Book> _books;
        private Book _selectedBook;

        public ObservableCollection<Book> Books
        {
            get => _books;
            set
            {
                _books = value;
                OnPropertyChanged(nameof(Books));
            }
        }

        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
                if (_selectedBook == null)
                {
                    SelectedBook = new Book(); 
                }
            }
        }

        public ICommand AddBookCommand { get; }
        public ICommand RemoveBookCommand { get; }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>
        {
            new Book { Title = "New Book", Author = "Unknown", Year = 2023 } 
        };

            AddBookCommand = new RelayCommand(AddBook);
            RemoveBookCommand = new RelayCommand(RemoveBook, CanRemoveBook);
        }

        private void AddBook()
        {
            if (SelectedBook != null && !string.IsNullOrWhiteSpace(SelectedBook.Title))
            {
                Books.Add(new Book
                {
                    Title = SelectedBook.Title,
                    Author = SelectedBook.Author,
                    Year = SelectedBook.Year
                });
                SelectedBook = new Book(); 
            }
        }

        private void RemoveBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
                SelectedBook = null;
            }
        }

        private bool CanRemoveBook()
        {
            return SelectedBook != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
