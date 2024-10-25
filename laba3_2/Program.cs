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
        var heroNames =
        from hero in _heroes
        where hero.Name.Contains("man")
        orderby hero.Name //задає поле і спосіб сортування.
        select hero.Name;
        foreach (var hero in heroNames)
        {
            Console.WriteLine(hero);
        }

        Console.WriteLine("\nСупергерої, що народилися в 1941 році:\n");
        var year = _heroes
        .Where(hero => hero.YearOfBirth == 1941)
        .Select(hero => hero.Name);
        foreach (var hero in year)
        {
            Console.WriteLine(hero);

        }
        Console.WriteLine("\nКомікси в алфавітному порядку:\n");
        var sortedComics = _heroes
            .Select(hero => hero.Comics)
            .OrderBy(comics => comics);

        foreach (var comics in sortedComics)
        {
            Console.WriteLine(comics);
        }

        Console.WriteLine("\nСупергерої та роки народження (спадання):\n");
        var heroesWithBirthYears = _heroes
            .OrderByDescending(hero => hero.YearOfBirth)
            .Select(hero => new { hero.Name, hero.YearOfBirth });


        foreach (var hero in heroesWithBirthYears)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }


    }
}
