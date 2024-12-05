using System;
using System.Windows;

namespace Lab12
{
    public partial class MainWindow : Window
    {
        private double _firstNumber = 0;
        private double _secondNumber = 0;
        private string _operation = "";
        private bool _isOperationClicked = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = (sender as System.Windows.Controls.Button).Content.ToString();

            if (_isOperationClicked)
            {
                Display.Text = value;
                _isOperationClicked = false;
            }
            else
            {
                if (Display.Text == "0")
                    Display.Text = value;
                else
                    Display.Text += value;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            _firstNumber = double.Parse(Display.Text);
            _operation = (sender as System.Windows.Controls.Button).Content.ToString();
            _isOperationClicked = true;
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _secondNumber = double.Parse(Display.Text);
                double result = 0;

                switch (_operation)
                {
                    case "+":
                        result = _firstNumber + _secondNumber;
                        break;
                    case "-":
                        result = _firstNumber - _secondNumber;
                        break;
                    case "*":
                        result = _firstNumber * _secondNumber;
                        break;
                    case "/":
                        result = _secondNumber != 0 ? _firstNumber / _secondNumber : double.NaN;
                        break;
                }

                Display.Text = result.ToString();
            }
            catch (Exception ex)
            {
                Display.Text = "Error";
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = "";
            _isOperationClicked = false;
        }
    }
}
