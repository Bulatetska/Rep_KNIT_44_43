using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1:
            Console.WriteLine("Task 1: ");

            Person p = new Person();
            p.changeName("Student");
            p.changeAge(20);
            p.changeGender("Male");
            p.changePhoneNumber("0504232354");
            p.Print();

            // task 2:

            Console.WriteLine("\nTask 2: ");

            Aspirant Petya = new Aspirant("Petya", 4, 34089, "Developing the web-site");
            Petya.Print();

            //task 3:

            Console.WriteLine("\nTask 3: ");

            BookGenrePubl book = new BookGenrePubl("Lord of the rings", "Ronald", "Tolkien", 350, "fiction", "Astroliabia");

            book.Print();

            //task 4:
            Console.WriteLine("\nTask 4: ");

            Figure figure;

            figure = new Rectangle("My Rectangle", 2, 3, 8, 10);
            figure.Display();

            figure = new RectangleColor("Colored Rectangle", 1, 1, 5, 4, "Red");
            figure.Display();

            Rectangle rect;
            rect = new RectangleColor("New Rectangle", 2, 6, 9, 10, "red");
            rect.Display();
            Console.WriteLine("Area: " + rect.Area());
            
        }
    }
}
