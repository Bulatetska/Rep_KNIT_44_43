using Lab11.Створення_WPF_додатку.Models;
using System;
using System.Collections.ObjectModel; // Для ObservableCollection
using System.ComponentModel;           // Для INotifyPropertyChanged
using System.Windows.Input;            // Для ICommand

namespace Lab11.Створення_WPF_додатку.ViewModels
{
    internal class BookViewModel : INotifyPropertyChanged
    {
        private Book _selectedBook;
        private string _newTitle;
        private string _newAuthor;
        private int _newYear;

        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();

        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                if (_selectedBook != value)
                {
                    _selectedBook = value;
                    OnPropertyChanged(nameof(SelectedBook));
                    ((RelayCommand)RemoveBookCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public string NewTitle
        {
            get => _newTitle;
            set
            {
                _newTitle = value;
                OnPropertyChanged(nameof(NewTitle));
            }
        }

        public string NewAuthor
        {
            get => _newAuthor;
            set
            {
                _newAuthor = value;
                OnPropertyChanged(nameof(NewAuthor));
            }
        }

        public int NewYear
        {
            get => _newYear;
            set
            {
                _newYear = value;
                OnPropertyChanged(nameof(NewYear));
            }
        }

        public ICommand AddBookCommand { get; }
        public ICommand RemoveBookCommand { get; }

        public BookViewModel()
        {
            AddBookCommand = new RelayCommand(AddBook);
            RemoveBookCommand = new RelayCommand(RemoveBook, CanRemoveBook);
        }

        private void AddBook()
        {
            Books.Add(new Book
            {
                Title = NewTitle,
                Author = NewAuthor,
                Year = NewYear
            });

            // Очистка полів після додавання
            NewTitle = string.Empty;
            NewAuthor = string.Empty;
            NewYear = 0;
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
