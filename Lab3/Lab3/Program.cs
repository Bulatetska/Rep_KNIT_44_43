using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks
{
    public class Program
    {
        private class Hero
        {
            public string Name { get; set; }
            public int YearOfBirth { get; set; }
            public string Comics { get; set; }
        }

        private static readonly List<Hero> _heroes = new List<Hero>
        {
            new Hero { Name = "Superman", YearOfBirth = 1938, Comics = "Action Comics" },
            new Hero { Name = "Batman", YearOfBirth = 1938, Comics = "Detective Comics" },
            new Hero { Name = "Captain America", YearOfBirth = 1941, Comics = "Captain America Comics" },
            new Hero { Name = "Ironman", YearOfBirth = 1963, Comics = "Tales of Suspense" },
            new Hero { Name = "Spiderman", YearOfBirth = 1963, Comics = "Amazing Fantasy" }
        };

        public static void Main(string[] args)
        {
            Console.WriteLine("1. Імена супергероїв, які народилися у 1941 році:");

            // Імперативний підхід
            var heroesBornIn1941Imperative = new List<string>();
            foreach (var hero in _heroes)
            {
                if (hero.YearOfBirth == 1941)
                {
                    heroesBornIn1941Imperative.Add(hero.Name);
                }
            }
            foreach (var name in heroesBornIn1941Imperative)
            {
                Console.WriteLine(name);
            }

            // Декларативний підхід (LINQ)
            var heroesBornIn1941Linq = _heroes
                .Where(hero => hero.YearOfBirth == 1941)
                .Select(hero => hero.Name);
            foreach (var name in heroesBornIn1941Linq)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n2. Назви коміксів в алфавітному порядку:");

            // Імперативний підхід
            var comicsNamesImperative = new List<string>();
            foreach (var hero in _heroes)
            {
                comicsNamesImperative.Add(hero.Comics);
            }
            comicsNamesImperative.Sort();
            foreach (var comics in comicsNamesImperative)
            {
                Console.WriteLine(comics);
            }

            // Декларативний підхід (LINQ)
            var comicsNamesLinq = _heroes
                .Select(hero => hero.Comics)
                .OrderBy(comics => comics);
            foreach (var comics in comicsNamesLinq)
            {
                Console.WriteLine(comics);
            }

            Console.WriteLine("\n3. Імена супергероїв та дати їх народження у порядку спадання:");

            // Імперативний підхід
            var heroesWithBirthDatesImperative = new List<Hero>(_heroes);
            heroesWithBirthDatesImperative.Sort((hero1, hero2) => hero2.YearOfBirth.CompareTo(hero1.YearOfBirth));
            foreach (var hero in heroesWithBirthDatesImperative)
            {
                Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
            }

            // Декларативний підхід (LINQ)
            var heroesWithBirthDatesLinq = _heroes
                .OrderByDescending(hero => hero.YearOfBirth)
                .Select(hero => $"{hero.Name} - {hero.YearOfBirth}");
            foreach (var hero in heroesWithBirthDatesLinq)
            {
                Console.WriteLine(hero);
            }
        }
    }
}
