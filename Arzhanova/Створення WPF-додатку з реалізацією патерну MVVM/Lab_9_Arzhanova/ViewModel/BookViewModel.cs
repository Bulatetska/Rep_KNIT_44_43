using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Lab_9_Arzhanova.Model;

namespace Lab_9_Arzhanova.ViewModel
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Book> books;
        private Book selectedBook;

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            SelectedBook = new Book(); // Ініціалізація SelectedBook
            AddBookCommand = new RelayCommand(AddBook);
            RemoveBookCommand = new RelayCommand(RemoveBook, CanRemoveBook);
        }


        public ObservableCollection<Book> Books
        {
            get => books;
            set
            {
                books = value;
                OnPropertyChanged(nameof(Books));
            }
        }

        public Book SelectedBook
        {
            get => selectedBook;
            set
            {
                selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
                // Ensure that RemoveBookCommand is of type RelayCommand
                (RemoveBookCommand as RelayCommand)?.RaiseCanExecuteChanged();
            }
        }

        public ICommand AddBookCommand { get; }
        public RelayCommand RemoveBookCommand { get; } // Change to RelayCommand

        private void AddBook()
        {
            Debug.WriteLine("AddBook called"); // Додайте цю стрічку для перевірки
            if (SelectedBook != null &&
                !string.IsNullOrWhiteSpace(SelectedBook.Title) &&
                !string.IsNullOrWhiteSpace(SelectedBook.Author) &&
                SelectedBook.Year > 0)
            {
                Books.Add(new Book
                {
                    Title = SelectedBook.Title,
                    Author = SelectedBook.Author,
                    Year = SelectedBook.Year
                });

                SelectedBook = new Book(); // Створити новий екземпляр Book для введення нових даних
                (RemoveBookCommand as RelayCommand)?.RaiseCanExecuteChanged(); // Оновити стан команди видалення

                Debug.WriteLine("Book added: " + SelectedBook.Title); // Ще одна перевірка
            }
            else
            {
                Debug.WriteLine("Invalid book details"); // Якщо книга не додалася, виводимо цю стрічку
            }
        }


        private void RemoveBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
                SelectedBook = new Book(); // Створити новий екземпляр Book після видалення
                (RemoveBookCommand as RelayCommand)?.RaiseCanExecuteChanged(); // Оновити стан команди видалення
            }
        }


        private bool CanRemoveBook()
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
