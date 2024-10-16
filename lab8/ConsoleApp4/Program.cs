using System;

// Оголошення делегата
public delegate double OperationDelegate(double a, double b);

// Клас MathOperations
public class MathOperations
{
    // Подія для сповіщення про виконання операцій
    public event Action<string>? OnOperationPerformed; // Додано знак питання для дозволу значення null

    // Метод для додавання двох чисел
    public double Add(double a, double b)
    {
        double result = a + b;
        OnOperationPerformed?.Invoke($"Додавання: {a} + {b} = {result}");
        return result;
    }

    // Метод для множення двох чисел
    public double Multiply(double a, double b)
    {
        double result = a * b;
        OnOperationPerformed?.Invoke($"Множення: {a} * {b} = {result}");
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення екземпляру MathOperations
        MathOperations mathOps = new MathOperations();

        // Оголошення делегата
        OperationDelegate operations = null;

        // Обробник подій
        mathOps.OnOperationPerformed += result => Console.WriteLine(result);

        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Додати");
        Console.WriteLine("2. Множити");
        Console.WriteLine("3. Інша операція (знайти різницю квадратів)");

        string choice = Console.ReadLine();
        double a, b;

        switch (choice)
        {
            case "1":
                Console.Write("Введіть перше число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                b = Convert.ToDouble(Console.ReadLine());
                // Додати метод додавання до делегата
                operations = mathOps.Add;
                Console.WriteLine($"Результат: {operations.Invoke(a, b)}");
                break;

            case "2":
                Console.Write("Введіть перше число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                b = Convert.ToDouble(Console.ReadLine());
                // Додати метод множення до делегата
                operations = mathOps.Multiply;
                Console.WriteLine($"Результат: {operations.Invoke(a, b)}");
                break;

            case "3":
                Console.Write("Введіть перше число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                b = Convert.ToDouble(Console.ReadLine());
                // Використання лямбда-виразу для знаходження різниці квадратів
                Func<double, double, double> differenceOfSquares = (x, y) => Math.Pow(x, 2) - Math.Pow(y, 2);
                double result = differenceOfSquares(a, b);
                Console.WriteLine($"Різниця квадратів: {result}");
                break;

            default:
                Console.WriteLine("Невірний вибір!");
                break;
        }
    }
}
