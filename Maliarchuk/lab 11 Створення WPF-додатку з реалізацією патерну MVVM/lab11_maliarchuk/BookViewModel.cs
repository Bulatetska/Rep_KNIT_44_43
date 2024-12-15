using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab11_maliarchuk
{
    public class BookViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Book> Books { get; set; }

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                _selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
                ((RelayCommand)RemoveBookCommand).RaiseCanExecuteChanged(); 
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

        private string _newTitle;
        public string NewTitle
        {
            get => _newTitle;
            set { _newTitle = value; OnPropertyChanged(nameof(NewTitle)); }
        }

        private string _newAuthor;
        public string NewAuthor
        {
            get => _newAuthor;
            set { _newAuthor = value; OnPropertyChanged(nameof(NewAuthor)); }
        }

        private int _newYear = DateTime.Now.Year;
        public int NewYear
        {
            get => _newYear;
            set { _newYear = value; OnPropertyChanged(nameof(NewYear)); }
        }

        private void AddBook()
        {
            Books.Add(new Book { Title = NewTitle, Author = NewAuthor, Year = NewYear });

            NewTitle = string.Empty;
            NewAuthor = string.Empty;
            NewYear = DateTime.Now.Year;
        }

        private bool CanRemoveBook()
        {
            return SelectedBook != null;
        }

        private void RemoveBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
