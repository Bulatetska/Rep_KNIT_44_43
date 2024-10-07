using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Program
    {
        private class Hero
        {
            public string Name { get; set; }
            public int YearOfBirth { get; set; }
            public string Comics { get; set; }
        }
        private static readonly List<Hero> _heroes = new List<Hero>
        {
         new Hero
         {
         Name = "Superman",
         YearOfBirth = 1938,
         Comics = "Action Comics"
         },
         new Hero
         {
         Name = "Batman",
         YearOfBirth = 1938,
         Comics = "Detective Comics"
         },
         new Hero
         {
         Name = "Captain America",
         YearOfBirth = 1941,
         Comics = "Captain America Comics"
         },
         new Hero
         {
         Name = "Ironman",
         YearOfBirth = 1963,
         Comics = "Tales of Suspense"
         },
         new Hero
         {
         Name = "Spiderman",
         YearOfBirth = 1963,
         Comics = "Amazing Fantasy"
         }
        };

        static void Main(string[] args)
        {
            //   Imperative way from lection:

            Console.WriteLine("Imperative way from lection:");

            var heroNamesLect = new List<string>();
            foreach (var hero in _heroes)
            {
                if (hero.Name.Contains("man"))
                {
                    heroNamesLect.Add(hero.Name);
                }
            }
            heroNamesLect.Sort();
            foreach (var heroName in heroNamesLect)
            {
                Console.WriteLine(heroName);
            }

            // Declarative way from lection:

            Console.WriteLine("\nDeclarative way from lection:");

            var heroNamesLect1 =
            from hero in _heroes
            where hero.Name.Contains("man")
            orderby hero.Name
            select hero.Name;
            foreach (var hero in heroNamesLect1)
            {
                Console.WriteLine(hero);
            }


            // ------------TASK-1------------

            // 1. Вивести імена супергероїв, які народилися 1941 р.

            Console.WriteLine("\nTask 1, Imperative method: ");

            // --IMPERATIVE-METHOD--

            var heroNames1 = new List<string>();
            foreach (var hero in _heroes)
            {
                if (hero.YearOfBirth == 1941)
                {
                    heroNames1.Add(hero.Name);
                }
            }
            heroNames1.Sort();
            foreach (var heroName in heroNames1)
            {
                Console.WriteLine(heroName);
            }

            // --DECLARTIVE-METHOD--

            Console.WriteLine("\nTask 1, Declarative method: ");

            var heroNamesD1 =
            from hero in _heroes
            where hero.YearOfBirth == 1941
            orderby hero.Name
            select hero.Name;

            foreach (var hero in heroNamesD1)
            {
                Console.WriteLine(hero);
            }


            //------------TASK-2------------

            // 2. Вивести назви коміксів і відсортувати їх в алфавітному порядку

            Console.WriteLine("\nTask 2, Imperative method: ");

            // --IMPERATIVE-METHOD--

            var heroNames2 = new List<string>();
            foreach (var hero in _heroes)
            {
                heroNames2.Add(hero.Comics);
            }
            heroNames2.Sort();
            foreach (var hero in heroNames2)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine("\nTask 2, Declarative method: ");

            // --DECLARTIVE-METHOD--

            var heroNames2D =
            from hero in _heroes
            orderby hero.Comics
            select hero.Comics;

            foreach (var hero in heroNames2D)
            {
                Console.WriteLine(hero);
            }


            // ------------TASK-3------------

            Console.WriteLine("\nTask 3, Imperative method: ");

            // --IMPERATIVE-METHOD--

            var heroNames3I = new List<(string Name, int YearOfBirth)>();
            foreach (var hero in _heroes)
            {
                heroNames3I.Add((hero.Name, hero.YearOfBirth));
            }

            heroNames3I.Sort((x, y) => y.YearOfBirth.CompareTo(x.YearOfBirth));

            foreach (var hero in heroNames3I)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine("\nTask 3, Declarative method: ");

            // --DECLARTIVE-METHOD--

            var heroNames3 =
            from hero in _heroes
            orderby hero.YearOfBirth descending
            select hero.Name + " " + hero.YearOfBirth;

            foreach (var hero in heroNames3)
            {
                Console.WriteLine(hero);
            }

        }
    }
}
