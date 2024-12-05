using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnConfirmButtonClick(object sender, RoutedEventArgs e)
        {
            string userName = NameInput.Text; // Отримуємо текст із текстового поля
            GreetingMessage.Text = $"Привіт, {userName}!"; // Встановлюємо текст привітання
        }
    }
}