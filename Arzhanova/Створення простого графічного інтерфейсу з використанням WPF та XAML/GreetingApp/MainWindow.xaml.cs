using System;
using System.Collections.Generic;
using System.Linq;
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

using System.ComponentModel;
using System.Windows;

namespace GreetingApp
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _userName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            // Прив'язуємо контекст даних до вікна
            this.DataContext = this;
        }

        // Метод для сповіщення про зміну властивості
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            // Виведення привітання через прив'язку даних
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                GreetingMessage.Text = $"Привіт, {UserName}!";
            }
            else
            {
                GreetingMessage.Text = "Будь ласка, введіть ім'я.";
            }
        }
    }
}
