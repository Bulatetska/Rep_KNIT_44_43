using System;
using System.Collections.Generic;
using System.Linq;

class Program {
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
    static void ExampleImp()
    {
        Console.WriteLine("\nПриклад: Імена супергероїв, які мають слово man (імперативний підхід)\n");
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
    } 

    static void ExampleDecl()
    {
        Console.WriteLine("\nПриклад: Імена супергероїв, які мають слово man (декларативний підхід)\n");
        var heroNames =
        from hero in _heroes
        where hero.Name.Contains("man")
        orderby hero.Name
        select hero.Name;
        foreach (var hero in heroNames)
        {
            Console.WriteLine(hero);
        }
    }
    static void Task1Imp()
    {
        Console.WriteLine("\nЗавдання 1: Імена супергероїв, які народилися в 1941 році (імперативний підхід)\n");

        foreach (var hero in _heroes)
        {
            if (hero.YearOfBirth == 1941)
            {
                Console.WriteLine(hero.Name);
            }
        }
    }
    static void Task1Decl()
    {
        Console.WriteLine("\nЗавдання 1: Імена супергероїв, які народилися в 1941 році (декларативний підхід)\n");

        var heroesBornIn1941 = _heroes
            .Where(hero => hero.YearOfBirth == 1941)
            .Select(hero => hero.Name);

        foreach (var name in heroesBornIn1941)
        {
            Console.WriteLine(name);
        }
    }
    static void Task2Imp()
    {
        Console.WriteLine("\nЗавдання 2: Назви коміксів в алфавітному порядку (імперативний підхід)\n");

        List<string> comicsNames = new List<string>();
        foreach (var hero in _heroes)
        {
            comicsNames.Add(hero.Comics);
        }
        comicsNames.Sort();

        foreach (var comic in comicsNames)
        {
            Console.WriteLine(comic);
        }
    }
    static void Task2Decl()
    {
        Console.WriteLine("\nЗавдання 2: Назви коміксів в алфавітному порядку (декларативний підхід)\n");

        var comicsNames = _heroes
            .Select(hero => hero.Comics)
            .OrderBy(comics => comics);

        foreach (var comic in comicsNames)
        {
            Console.WriteLine(comic);
        }
    }
    static void Task3Imp()
    {
        Console.WriteLine("\nЗавдання 3: Імена супергероїв та дати народження в порядку спадання (імперативний підхід)\n");

        List<Hero> sortedHeroes = new List<Hero>(_heroes);
        sortedHeroes.Sort((hero1, hero2) => hero2.YearOfBirth.CompareTo(hero1.YearOfBirth));

        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }
    }
    static void Task3Decl()
    {
        Console.WriteLine("\nЗавдання 3: Імена супергероїв та дати народження в порядку спадання (декларативний підхід)\n");

        var sortedHeroes = _heroes
            .OrderByDescending(hero => hero.YearOfBirth)
            .Select(hero => $"{hero.Name} - {hero.YearOfBirth}");

        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine(hero);
        }
    }

    static void Main(string[] args)
    {
        ExampleImp();
        ExampleDecl();
        Task1Imp();
        Task1Decl();
        Task2Imp();
        Task2Decl();
        Task3Imp();
        Task3Decl();
    } 

}
