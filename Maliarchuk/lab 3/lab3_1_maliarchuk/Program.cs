using System;

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



        Console.WriteLine("\nСупергерої, що народилися в 1941 році:");
        foreach (var hero in _heroes)
        {
            if (hero.YearOfBirth == 1941)
            {
                Console.WriteLine(hero.Name);
            }
        }

        var comicsNames = new List<string>();
        foreach (var hero in _heroes)
        {
            comicsNames.Add(hero.Comics);
        }

        comicsNames.Sort();



        Console.WriteLine("\nКомікси в алфавітному порядку:");
        foreach (var comics in comicsNames)
        {
            Console.WriteLine(comics);
        }

        var sortedHeroes = _heroes.OrderByDescending(hero => hero.YearOfBirth).ToList();



        Console.WriteLine("\nСупергерої та роки народження (спадання):");
        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }
    }
}

