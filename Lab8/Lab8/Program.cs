using System;

namespace MathOperationsExample
{
    // Клас для математичних операцій
    public class MathOperations
    {
        // Оголошення делегата
        public delegate double OperationDelegate(double a, double b);

        // Подія, яка спрацьовує після виконання операції
        public event EventHandler<string> OnOperationPerformed;

        // Метод додавання
        public double Add(double a, double b)
        {
            double result = a + b;
            OnOperationPerformed?.Invoke(this, $"Додавання: {a} + {b} = {result}");
            return result;
        }

        // Метод множення
        public double Multiply(double a, double b)
        {
            double result = a * b;
            OnOperationPerformed?.Invoke(this, $"Множення: {a} * {b} = {result}");
            return result;
        }

        // Метод для виконання іншої операції за допомогою лямбда-виразу
        public double PerformCustomOperation(Func<double, double, double> operation, double a, double b)
        {
            double result = operation(a, b);
            OnOperationPerformed?.Invoke(this, $"Спеціальна операція: {a} і {b} = {result}");
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляра класу MathOperations
            MathOperations mathOps = new MathOperations();

            // Додавання обробника події для виведення результату
            mathOps.OnOperationPerformed += (sender, e) => Console.WriteLine(e);

            // Оголошення делегата і додавання методів
            MathOperations.OperationDelegate operations = mathOps.Add;
            operations += mathOps.Multiply;

            // Вибір користувача для операції
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1 - Додавання");
            Console.WriteLine("2 - Множення");
            Console.WriteLine("3 - Спеціальна операція (різниця квадратів)");
            string choice = Console.ReadLine();

            double a, b;
            Console.WriteLine("Введіть перше число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            b = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    // Виклик операції додавання через делегат
                    operations.Invoke(a, b);
                    break;

                case "2":
                    // Виклик операції множення через делегат
                    operations.Invoke(a, b);
                    break;

                case "3":
                    // Лямбда-вираз для обчислення різниці квадратів
                    var customOperation = new Func<double, double, double>((x, y) => (x * x) - (y * y));
                    mathOps.PerformCustomOperation(customOperation, a, b);
                    break;

                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }

            Console.WriteLine("Операції завершено.");
        }
    }
}
