using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        int lastIndex = -1;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'i' || input[i] == 'I' || input[i] == 'і' || input[i] == 'І')
            {
                lastIndex = i; 
            }
        }

        if (lastIndex != -1) 
        {
            Console.WriteLine($"Остання буква 'і' знаходиться на позиції: {lastIndex + 1}");
        }
        else 
        {
            Console.WriteLine("Буква 'і' у рядку відсутня.");
        }
    }
}
