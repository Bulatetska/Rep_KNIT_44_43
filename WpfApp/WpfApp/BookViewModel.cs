using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp
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
                OnPropertyChanged();
            }
        }

        // Текстові властивості для введення значень
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        // Конструктор
        public BookViewModel()
        {
            Books = new ObservableCollection<Book>();
            AddBookCommand = new RelayCommand(AddBook);
            RemoveBookCommand = new RelayCommand(RemoveBook, CanRemoveBook);
        }

        // Команди
        public ICommand AddBookCommand { get; }
        public ICommand RemoveBookCommand { get; }

        // Метод для додавання книги
        private void AddBook()
        {
            if (!string.IsNullOrEmpty(Title) && !string.IsNullOrEmpty(Author) && Year > 0)
            {
                Books.Add(new Book
                {
                    Title = Title,
                    Author = Author,
                    Year = Year
                });

                // Очистити поля після додавання
                Title = string.Empty;
                Author = string.Empty;
                Year = 0;

                // Оновити властивості для відображення в UI
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(Author));
                OnPropertyChanged(nameof(Year));
            }
        }

        // Метод для видалення книги
        private void RemoveBook()
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
            }
        }

        // Умова для активації команди видалення
        private bool CanRemoveBook()
        {
            return SelectedBook != null;
        }

        // Оповіщення про зміну властивості
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
