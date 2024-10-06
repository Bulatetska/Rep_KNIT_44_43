using System.Collections.Generic;
using System.Linq;

class Superhero
{
    public string Name { get; set; }
    public int BirthYear { get; set; }
    public List<string> Comics { get; set; }

    public Superhero(string name, int birthYear, List<string> comics)
    {
        Name = name;
        BirthYear = birthYear;
        Comics = comics;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Superhero> superheroes = new List<Superhero>
        {
            new Superhero("Spider-Man", 1962, new List<string> { "Amazing Fantasy", "Spider-Man" }),
            new Superhero("Wonder Woman", 1941, new List<string> { "Wonder Woman", "Justice League" }),
            new Superhero("Captain America", 1941, new List<string> { "Captain America" }),
            new Superhero("Batman", 1939, new List<string> { "Batman", "Justice League" }),
            new Superhero("Superman", 1938, new List<string> { "Action Comics", "Superman" }),
            new Superhero("Iron Man", 1963, new List<string> { "Iron Man", "Avengers" }),
            new Superhero("Detective Comics", 1937, new List<string> { "Detective Comics" }),
            new Superhero("Avengers", 1963, new List<string> { "Avengers" }),
            new Superhero("Fantastic Four", 1961, new List<string> { "Fantastic Four" }),
            new Superhero("Justice League", 1960, new List<string> { "Justice League" })
        };

        // Завдання 1
        Task1_Imperative(superheroes);
        Task1_Declarative(superheroes);

        // Завдання 2
        Task2_Imperative(superheroes);
        Task2_Declarative(superheroes);

        // Завдання 3
        Task3_Imperative(superheroes);
        Task3_Declarative(superheroes);
    }

    // Завдання 1: Вивести імена супергероїв, які народилися 1941 р.
    static void Task1_Imperative(List<Superhero> superheroes)
    {
        Console.WriteLine("Завдання 1 (імперативний підхід):");
        foreach (var hero in superheroes)
        {
            if (hero.BirthYear == 1941)
            {
                Console.WriteLine(hero.Name);
            }
        }
    }

    static void Task1_Declarative(List<Superhero> superheroes)
    {
        Console.WriteLine("Завдання 1 (декларативний підхід):");
        var heroesBornIn1941 = superheroes.Where(h => h.BirthYear == 1941).Select(h => h.Name);
        foreach (var hero in heroesBornIn1941)
        {
            Console.WriteLine(hero);
        }
    }

    // Завдання 2: Вивести назви коміксів і відсортувати їх в алфавітному порядку
    static void Task2_Imperative(List<Superhero> superheroes)
    {
        Console.WriteLine("Завдання 2 (імперативний підхід):");
        HashSet<string> comics = new HashSet<string>();

        foreach (var hero in superheroes)
        {
            foreach (var comic in hero.Comics)
            {
                comics.Add(comic);
            }
        }

        List<string> sortedComics = comics.ToList();
        sortedComics.Sort();

        foreach (var comic in sortedComics)
        {
            Console.WriteLine(comic);
        }
    }

    static void Task2_Declarative(List<Superhero> superheroes)
    {
        Console.WriteLine("Завдання 2 (декларативний підхід):");
        var sortedComics = superheroes.SelectMany(h => h.Comics).Distinct().OrderBy(c => c);

        foreach (var comic in sortedComics)
        {
            Console.WriteLine(comic);
        }
    }

    // Завдання 3: Вивести імена супергероїв та дати їх народження і відсортувати їх в порядку спадання дат їх народження
    static void Task3_Imperative(List<Superhero> superheroes)
    {
        Console.WriteLine("Завдання 3 (імперативний підхід):");
        var sortedHeroes = superheroes.OrderByDescending(h => h.BirthYear);

        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine($"{hero.Name}: {hero.BirthYear}");
        }
    }

    static void Task3_Declarative(List<Superhero> superheroes)
    {
        Console.WriteLine("Завдання 3 (декларативний підхід):");
        var sortedHeroes = superheroes.OrderByDescending(h => h.BirthYear)
                                       .Select(h => $"{h.Name}: {h.BirthYear}");

        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine(hero);
        }
    }
}
