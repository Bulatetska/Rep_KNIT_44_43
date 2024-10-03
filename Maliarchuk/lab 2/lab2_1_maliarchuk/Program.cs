using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість чисел у масиві: ");
        int CountOfNumbers = Convert.ToInt32(Console.ReadLine());

        double[] numbers = new double[CountOfNumbers];

        for (int i = 0; i < CountOfNumbers; i++)
        {
            Console.Write("Введіть число масиву: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double maxElement = numbers[0];
        int firstMaxIndex = 0;
        int countMax = 1;

        for (int i = 1; i < CountOfNumbers; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = numbers[i];
                firstMaxIndex = i;
                countMax = 1; 
            }
            else if (numbers[i] == maxElement)
            {
                countMax++; 
            }
        }

        Console.WriteLine("Максимальний елемент: " + maxElement);
        Console.WriteLine("Кількість повторень максимального елемента: " + countMax);
        Console.WriteLine("Перший індекс максимального елемента: " + (firstMaxIndex + 1) ); 
    }
}
