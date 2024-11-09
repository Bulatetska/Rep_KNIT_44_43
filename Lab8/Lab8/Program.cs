using System;

namespace DelegateEventExample
{
    // Оголошення делегата для операцій
    public delegate double OperationDelegate(double a, double b);

    // Клас MathOperations, що містить методи додавання, множення та подію
    public class MathOperations
    {
        // Подія, що спрацьовує після виконання математичної операції
        public event EventHandler<double> OnOperationPerformed;

        // Метод додавання
        public double Add(double a, double b)
        {
            double result = a + b;
            OperationPerformed(result);
            return result;
        }

        // Метод множення
        public double Multiply(double a, double b)
        {
            double result = a * b;
            OperationPerformed(result);
            return result;
        }

        // Викликає подію після виконання операції
        public virtual void OperationPerformed(double result) // Змінили protected на public
        {
            OnOperationPerformed?.Invoke(this, result);
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення екземпляра MathOperations
            MathOperations mathOps = new MathOperations();

            // Підписка на подію для виведення результату
            mathOps.OnOperationPerformed += (sender, result) =>
            {
                Console.WriteLine($"Результат операції: {result}");
            };

            // Оголошення делегата і додавання методів до нього
            OperationDelegate operations = mathOps.Add;
            operations += mathOps.Multiply;

            // Виконання додавання через делегат
            Console.WriteLine("Виконання додавання та множення:");
            operations(3, 4);

            // Використання лямбда-виразу для обчислення різниці квадратів
            OperationDelegate differenceOfSquares = (a, b) =>
            {
                double result = (a * a) - (b * b);
                mathOps.OperationPerformed(result);
                return result;
            };

            // Використання лямбда-виразу для обчислення квадратного кореня суми квадратів
            OperationDelegate squareRootOfSumSquares = (a, b) =>
            {
                double result = Math.Sqrt(a * a + b * b);
                mathOps.OperationPerformed(result);
                return result;
            };

            // Тестування додаткових операцій
            Console.WriteLine("\nВиконання різниці квадратів:");
            differenceOfSquares(5, 3);

            Console.WriteLine("\nВиконання квадратного кореня суми квадратів:");
            squareRootOfSumSquares(3, 4);
        }
    }
}
