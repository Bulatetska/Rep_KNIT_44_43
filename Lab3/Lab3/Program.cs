using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    // Hero class
    class Hero
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string Comics { get; set; }
    }

    class Program
    {
        // Test data - list of heroes
        private static readonly List<Hero> _heroes = new List<Hero>
        {
            new Hero { Name = "Superman", YearOfBirth = 1938, Comics = "Action Comics" },
            new Hero { Name = "Batman", YearOfBirth = 1938, Comics = "Detective Comics" },
            new Hero { Name = "Captain America", YearOfBirth = 1941, Comics = "Captain America Comics" },
            new Hero { Name = "Ironman", YearOfBirth = 1963, Comics = "Tales of Suspense" },
            new Hero { Name = "Spiderman", YearOfBirth = 1963, Comics = "Amazing Fantasy" }
        };

        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("\nSelect a task to perform:");
                Console.WriteLine("1 - Show the names of heroes born in 1941.");
                Console.WriteLine("2 - Show comic names sorted alphabetically.");
                Console.WriteLine("3 - Show hero names and birth years sorted by descending birth year.");
                Console.WriteLine("0 - Exit the program.");

                Console.Write("\nYour choice: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "0":
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Task 1: Show the names of heroes born in 1941
        static void Task1()
        {
            // Imperative approach
            Console.WriteLine("\nNames of heroes born in 1941 (imperative approach):");
            foreach (var hero in _heroes)
            {
                if (hero.YearOfBirth == 1941)
                {
                    Console.WriteLine(hero.Name);
                }
            }

            // Declarative approach (LINQ)
            var heroes1941 = from hero in _heroes
                             where hero.YearOfBirth == 1941
                             select hero.Name;

            Console.WriteLine("\nNames of heroes born in 1941 (declarative approach):");
            foreach (var name in heroes1941)
            {
                Console.WriteLine(name);
            }
        }

        // Task 2: Show comic names sorted alphabetically
        static void Task2()
        {
            // Imperative approach
            Console.WriteLine("\nComic names sorted alphabetically (imperative approach):");
            List<string> comics = new List<string>();
            foreach (var hero in _heroes)
            {
                comics.Add(hero.Comics);
            }
            comics.Sort();

            foreach (var comic in comics)
            {
                Console.WriteLine(comic);
            }

            // Declarative approach (LINQ)
            var sortedComics = from hero in _heroes
                               orderby hero.Comics
                               select hero.Comics;

            Console.WriteLine("\nComic names sorted alphabetically (declarative approach):");
            foreach (var comic in sortedComics)
            {
                Console.WriteLine(comic);
            }
        }

        // Task 3: Show hero names and birth years sorted by descending birth year
        static void Task3()
        {
            // Imperative approach
            Console.WriteLine("\nHero names and birth years sorted by descending year (imperative approach):");
            List<Hero> sortedHeroes = new List<Hero>(_heroes);
            sortedHeroes.Sort((hero1, hero2) => hero2.YearOfBirth.CompareTo(hero1.YearOfBirth));

            foreach (var hero in sortedHeroes)
            {
                Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
            }

            // Declarative approach (LINQ)
            var sortedHeroesByYear = from hero in _heroes
                                     orderby hero.YearOfBirth descending
                                     select new { hero.Name, hero.YearOfBirth };

            Console.WriteLine("\nHero names and birth years sorted by descending year (declarative approach):");
            foreach (var hero in sortedHeroesByYear)
            {
                Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
            }
        }
    }
}
