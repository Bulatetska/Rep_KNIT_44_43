using System;

public class MathOperations
{
    // Делегат для математичних операцій
    public delegate double OperationDelegate(double a, double b);

    // Подія, яка викликається після виконання операції
    public event Action<double> OnOperationPerformed;

    // Метод додавання
    public double Add(double a, double b)
    {
        double result = a + b;
        OnOperationPerformed?.Invoke(result);
        return result;
    }

    // Метод множення
    public double Multiply(double a, double b)
    {
        double result = a * b;
        OnOperationPerformed?.Invoke(result);
        return result;
    }

    // Метод для виклику делегата
    public void PerformOperation(OperationDelegate operation, double a, double b)
    {
        double result = operation(a, b);
        Console.WriteLine($"Result: {result}");
    }
}

public class Program
{
    public static void Main()
    {
        // Створюємо екземпляр MathOperations
        MathOperations mathOperations = new MathOperations();

        // Підписуємося на подію для виведення результату
        mathOperations.OnOperationPerformed += result =>
        {
            Console.WriteLine($"Operation performed, result: {result}");
        };

        // Створюємо делегат і додаємо до нього методи додавання і множення
        MathOperations.OperationDelegate operation = mathOperations.Add;
        operation += mathOperations.Multiply;

        // Викликаємо додавання та множення через делегат
        mathOperations.PerformOperation(operation, 5, 3);

        // Використання лямбда-виразу для складнішої операції (різниця квадратів двох чисел)
        MathOperations.OperationDelegate lambdaOperation = (a, b) =>
        {
            double result = (a * a) - (b * b);
            return result;
        };

        // Виконання операції через лямбда-вираз
        mathOperations.PerformOperation(lambdaOperation, 6, 4);

        // Інший приклад з лямбда-виразом (корінь суми квадратів двох чисел)
        MathOperations.OperationDelegate sqrtSumSquares = (a, b) =>
        {
            double result = Math.Sqrt((a * a) + (b * b));
            return result;
        };

        // Виклик операції з лямбда-виразом
        mathOperations.PerformOperation(sqrtSumSquares, 3, 4);
    }
}
