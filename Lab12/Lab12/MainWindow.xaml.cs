using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Lab12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                DisplayTextBox.Text += button.Content.ToString();
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (DisplayTextBox.Text.Length > 0 && !IsOperator(DisplayTextBox.Text[^1]))
                {
                    DisplayTextBox.Text += " " + button.Content.ToString() + " ";
                }
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DisplayTextBox.Text.Contains("/ 0"))
                {
                    DisplayTextBox.Text = "Cannot divide by zero";
                    return;
                }

                var result = new DataTable().Compute(DisplayTextBox.Text, null);

                if (result is double doubleResult && (double.IsInfinity(doubleResult) || double.IsNaN(doubleResult)))
                {
                    DisplayTextBox.Text = "Invalid Input";
                }
                else
                {
                    DisplayTextBox.Text = result.ToString();
                }
            }
            catch (Exception)
            {
                DisplayTextBox.Text = "Invalid Input";
            }
        }


        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayTextBox.Text = string.Empty; 
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
    }
}
