using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _greetingMessage;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; // Встановлюємо DataContext для прив'язки даних
        }

        public string GreetingMessage
        {
            get { return _greetingMessage; }
            set
            {
                _greetingMessage = value;
                OnPropertyChanged();
            }
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            // Отримуємо ім'я з текстового поля
            string userName = NameTextBox.Text;

            // Оновлюємо властивість для прив'язки
            GreetingMessage = $"Привіт, {userName}!";
        }

        // Реалізація INotifyPropertyChanged для оновлення UI
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
