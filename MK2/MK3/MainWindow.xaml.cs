using System;
using System.Windows;

namespace MK3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                ResultTextBlock.Text = "Поле не може бути порожнім. Введіть текст.";
                return;
            }

            string result = NormalizeSpaces(input);

            ResultTextBlock.Text = $"Результат: {result}";
        }

        private string NormalizeSpaces(string input)
        {
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }
    }
}
