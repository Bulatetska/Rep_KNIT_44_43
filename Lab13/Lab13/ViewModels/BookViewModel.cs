using Lab13;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Lab13
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private Book selectedBook;

        public ObservableCollection<Book> Books { get; set; }

        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                if (selectedBook != value)
                {
                    selectedBook = value;
                    OnPropertyChanged(nameof(SelectedBook));
                }
            }
        }

        public ICommand AddBookCommand { get; }
        public ICommand DeleteBookCommand { get; }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            AddBookCommand = new RelayCommand(AddBook);
            DeleteBookCommand = new RelayCommand(DeleteBook, CanDeleteBook);
        }

        private void AddBook()
        {
            Books.Add(new Book { Title = "New Book", Author = "Unknown", Year = 2024 });
        }

        private void DeleteBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
            }
        }

        private bool CanDeleteBook()
        {
            return SelectedBook != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
