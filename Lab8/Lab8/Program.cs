using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{

    public delegate double OperationDelegate(double a, double b);

    public class MathOperations
    {
        public event Action<string> OnOperationPerformed;

        public double Add(double a, double b)
        {
            double result = a + b;
            OnOperationPerformed?.Invoke($"Addition: {a} + {b} = {result}");
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            OnOperationPerformed?.Invoke($"Multiplication: {a} * {b} = {result}");
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            mathOps.OnOperationPerformed += (message) => Console.WriteLine(message);

            OperationDelegate operations = null;

            operations += mathOps.Add;
            operations += mathOps.Multiply;

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Multiply");
            Console.WriteLine("3. Other (Difference of squares)");

            int choice = int.Parse(Console.ReadLine());

            double a, b;

            Console.WriteLine("Enter first number:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double sumResult = operations.Invoke(a, b);
                    Console.WriteLine($"Result: {sumResult}");
                    break;
                case 2:
                    double multiplyResult = operations.Invoke(a, b);
                    Console.WriteLine($"Result: {multiplyResult}");
                    break;
                case 3:
                    Func<double, double, double> differenceOfSquares = (x, y) => (x * x) - (y * y);
                    double differenceResult = differenceOfSquares(a, b);
                    Console.WriteLine($"Result of difference of squares: {differenceResult}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
