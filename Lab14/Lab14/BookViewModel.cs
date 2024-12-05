
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Lab14
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private Book _selectedBook;

        public ObservableCollection<Book> Books { get; set; }
        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public ICommand AddBookCommand { get; }
        public ICommand RemoveBookCommand { get; }

        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            AddBookCommand = new RelayCommand(AddBook);
            RemoveBookCommand = new RelayCommand(RemoveBook, CanRemoveBook);
        }

        private void AddBook()
        {
            Books.Add(new Book { Title = "Untitled", Author = "Unknown", Year = DateTime.Now.Year });
        }


        private void RemoveBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
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

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute();
        public void Execute(object parameter) => _execute();
        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
