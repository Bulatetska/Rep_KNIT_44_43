using System;

public delegate double OperationDelegate(double a, double b);

public class MathOperations
{
    public event Action<double> OnOperationPerformed;

    protected void RaiseOnOperationPerformed(double result)
    {
        OnOperationPerformed?.Invoke(result);
    }

    public double Add(double a, double b)
    {
        double result = a + b;
        RaiseOnOperationPerformed(result);
        return result;
    }

    public double Multiply(double a, double b)
    {
        double result = a * b;
        RaiseOnOperationPerformed(result);
        return result;
    }
}


class Program
{
    static void Main(string[] args)
    {
        MathOperations mathOps = new MathOperations();

        mathOps.OnOperationPerformed += result =>
        {
            Console.WriteLine($"Результат операції: {result}");
        };

        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1 - Додавання");
        Console.WriteLine("2 - Множення");
        Console.WriteLine("3 - Різниця квадратів");
        Console.WriteLine("4 - Квадратний корінь суми квадратів");

        int choice = int.Parse(Console.ReadLine());
        double a, b;

        Console.Write("Введіть перше число: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        b = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Додавання: {mathOps.Add(a, b)}");
                break;

            case 2:
                Console.WriteLine($"Множення: {mathOps.Multiply(a, b)}");
                break;

            case 3:
                OperationDelegate diffSquares = (x, y) => (x * x) - (y * y);
                double diffResult = diffSquares(a, b);
                mathOps.GetType()
                    .GetMethod("RaiseOnOperationPerformed", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .Invoke(mathOps, new object[] { diffResult });
                Console.WriteLine($"Різниця квадратів: {diffResult}");
                break;

            case 4:
                OperationDelegate sqrtSumSquares = (x, y) => Math.Sqrt((x * x) + (y * y));
                double sqrtResult = sqrtSumSquares(a, b);
                mathOps.GetType()
                    .GetMethod("RaiseOnOperationPerformed", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
                    .Invoke(mathOps, new object[] { sqrtResult });
                Console.WriteLine($"Квадратний корінь суми квадратів: {sqrtResult}");
                break;

            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }
}
