using System;

public delegate double OperationDelegate(double a, double b);

public class MathOperations
{
    // Подія, що спрацьовує після виконання операції
    public event Action<string> OnOperationPerformed;

    // Метод для додавання
    public double Add(double a, double b)
    {
        double result = a + b;
        OnOperationPerformed?.Invoke($"Addition: {a} + {b} = {result}");
        return result;
    }

    // Метод для множення
    public double Multiply(double a, double b)
    {
        double result = a * b;
        OnOperationPerformed?.Invoke($"Multiplication: {a} * {b} = {result}");
        return result;
    }
}

class Program
{
    static void Main()
    {
        MathOperations mathOperations = new MathOperations();

        // Оголошення делегата
        OperationDelegate operations = null;

        // Додавання методів до делегата
        operations += mathOperations.Add;
        operations += mathOperations.Multiply;

        // Підписка на подію
        mathOperations.OnOperationPerformed += (message) =>
        {
            Console.WriteLine(message);
        };

        // Запит користувача
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Multiply");
        Console.WriteLine("3. Custom Operation (Difference of Squares)");
        int choice = int.Parse(Console.ReadLine());

        double a, b;
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter two numbers:");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double sumResult = operations.Invoke(a, b);
                Console.WriteLine($"Result: {sumResult}");
                break;

            case 2:
                Console.WriteLine("Enter two numbers:");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double multiplyResult = operations.Invoke(a, b);
                Console.WriteLine($"Result: {multiplyResult}");
                break;

            case 3:
                Console.WriteLine("Enter two numbers:");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                // Використання лямбда-виразу для знаходження різниці квадратів
                var customOperation = (double x, double y) => (x * x) - (y * y);
                double customResult = customOperation(a, b);
                Console.WriteLine($"Difference of squares: {customResult}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
