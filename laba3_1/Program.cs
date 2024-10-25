using System;
using System.Linq;

class Program
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
        Console.WriteLine("Супергерої,чиї імена містять слово 'man':\n");
        var heroNames = new List<string>();
        foreach (var hero in _heroes)
        {
            if (hero.Name.Contains("man"))
            {
                heroNames.Add(hero.Name);
            }
        }
        heroNames.Sort();
        foreach (var heroName in heroNames)
        {
            Console.WriteLine(heroName);
        }


        Console.WriteLine("\nСупергерої, що народилися в 1941 році:\n");
        foreach (var hero in _heroes)
        {
            if (hero.YearOfBirth == 1941)
            {
                Console.WriteLine(hero.Name);
            }
        }
        
        
        Console.WriteLine("\nНазви коміксів:\n");
        var comics = new List<string>();
        foreach (var hero in _heroes)
        {

            comics.Add(hero.Comics);

        }
        comics.Sort();
        foreach (var comicsort in comics)
        {
            Console.WriteLine(comicsort);
        }

        var sortedHeroes = _heroes.OrderByDescending(hero => hero.YearOfBirth).ToList();

        Console.WriteLine("\nСупергерої та роки народження (спадання):\n");
        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }


    }
}