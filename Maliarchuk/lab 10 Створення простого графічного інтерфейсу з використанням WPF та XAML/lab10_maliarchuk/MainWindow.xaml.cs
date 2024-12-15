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

namespace lab10_maliarchuk
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnConfirmClick(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                GreetingMessage.Text = $"Привіт, {name}!";
            }
            else
            {
                GreetingMessage.Text = "Будь ласка, введіть ім'я!";
            }
        }
    }
}
