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
        var heroNames =
            from hero in _heroes
            where hero.Name.Contains("man")
            orderby hero.Name
            select hero.Name;
        foreach (var hero in heroNames)
        {
            Console.WriteLine(hero);
        }



        var heroesBornIn1941 = _heroes
            .Where(hero => hero.YearOfBirth == 1941)
            .Select(hero => hero.Name);

        Console.WriteLine("\nСупергерої, що народилися в 1941 році:");
        foreach (var hero in heroesBornIn1941)
        {
            Console.WriteLine(hero);
        }



        var sortedComicsNames = _heroes
            .Select(hero => hero.Comics)
            .OrderBy(comics => comics);

        Console.WriteLine("\nКомікси в алфавітному порядку:");
        foreach (var comics in sortedComicsNames)
        {
            Console.WriteLine(comics);
        }



        var heroesWithBirthYears = _heroes
            .OrderByDescending(hero => hero.YearOfBirth)
            .Select(hero => new { hero.Name, hero.YearOfBirth });

        Console.WriteLine("\nСупергерої та роки народження (спадання):");
        foreach (var hero in heroesWithBirthYears)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }
    }
}

