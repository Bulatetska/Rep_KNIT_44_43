using System;

namespace DelegateLambdaEvents
{
    // Оголошення делегата OperationDelegate
    public delegate double OperationDelegate(double a, double b);
    // Клас MathOperations
    public class MathOperations
    {
        // Подія, яка буде спрацьовувати після виконання операції
        public event Action<double> OnOperationPerformed;

        // Метод додавання
        public double Add(double a, double b)
        {
            double result = a + b;
            OnOperationPerformed?.Invoke(result); // Виклик події
            return result;
        }

        // Метод множення
        public double Multiply(double a, double b)
        {
            double result = a * b;
            OnOperationPerformed?.Invoke(result); // Виклик події
            return result;
        }

        // Метод для виклику події вручну (для лямбда-виразу)
        public void PerformOperation(double result)
        {
            OnOperationPerformed?.Invoke(result); // Виклик події
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створити екземпляр класу MathOperations
            MathOperations mathOperations = new MathOperations();

            // Підписатися на подію для виведення результату операції
            mathOperations.OnOperationPerformed += result => Console.WriteLine($"Результат операції: {result}");

            // Оголошення делегата
            OperationDelegate operationDelegate;

            // Додати метод додавання і множення до делегата
            operationDelegate = mathOperations.Add;
            operationDelegate += mathOperations.Multiply;

            // Викликати операції через делегат
            double a = 3;
            double b = 4;

            Console.WriteLine("Виклик методів Add і Multiply через делегат:");
            operationDelegate(a, b); // Виклик обох операцій через груповий делегат

            // Використати лямбда-вираз для специфічної операції (наприклад, різниця квадратів двох чисел)
            OperationDelegate lambdaOperation = (x, y) => x * x - y * y;
            Console.WriteLine("\nВикористання лямбда-виразу для різниці квадратів:");
            double result = lambdaOperation(a, b);
            mathOperations.PerformOperation(result);

            // Інший приклад з лямбда-виразом для обчислення кореня суми квадратів
            lambdaOperation = (x, y) => Math.Sqrt(x * x + y * y);
            Console.WriteLine("\nВикористання лямбда-виразу для кореня суми квадратів:");
            result = lambdaOperation(a, b);
            mathOperations.PerformOperation(result);
        }
    }
}
