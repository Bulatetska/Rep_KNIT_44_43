using ConsoleApplication8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Демонстрація поліморфізму з використанням
            // абстрактного класу.
            // 1. Оголосити посилання на базовий клас
            Figure refFg;
            // 2. Оголосити екземпляр класу Figure
            // 2.1. Неможливо створити екземпляр абстрактного класу
            // Figure objFg = new Figure("Figure"); - помилка!
            // 2.2. Оголосити екземпляри класів Triangle, TriangleColor
            Triangle Tr = new Triangle("Triangle", 2, 3, 2);
            TriangleColor TrCol = new TriangleColor("TriangleColor", 1, 3, 3, 0);
            // 3. Демонстрація поліморфізму на прикладі методу Print()
            refFg = Tr;
            refFg.Print();
            refFg = TrCol;
            refFg.Print();
            // 4. Демонстрація поліморфізму на прикладі методу Area()
            refFg = Tr;
            refFg.Area(); // викликається метод Triangle.Area()
            refFg = TrCol;
            refFg.Area(); // викликається метод TriangleColor.Area()
                          // 5. Демонстрація поліморфізму на прикладі властивості Area2
            refFg = Tr;
            double area = refFg.Area2; // властивість Triangle.Area2
            Console.WriteLine("area = {0:f3}", area);
            refFg = TrCol;
            area = refFg.Area2; // властивість TriangleColor.Area2
            Console.WriteLine("area = {0:f3}", area);
            Console.ReadKey();
        }
    }
}
