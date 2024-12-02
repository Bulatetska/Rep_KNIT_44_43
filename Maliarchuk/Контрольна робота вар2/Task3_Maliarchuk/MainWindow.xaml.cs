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

namespace Task3_Maliarchuk
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

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            int lastIndex = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'і' || input[i] == 'І')
                {
                    lastIndex = i;
                }
            }

            if (lastIndex != -1)
            {
                ResultTextBlock.Text = $"Остання літера 'і' знаходиться на позиції: {lastIndex+1}";
            }
            else
            {
                ResultTextBlock.Text = "Буква 'і' у рядку відсутня.";
            }
        }
    }
}
