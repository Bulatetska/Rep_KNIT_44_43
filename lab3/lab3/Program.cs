using System;
using System.Collections.Generic;
using System.Linq;

public class Superhero
{
    public string Name { get; set; }
    public int BirthYear { get; set; }
    public string ComicTitle { get; set; }

    public Superhero(string name, int birthYear, string comicTitle)
    {
        Name = name;
        BirthYear = birthYear;
        ComicTitle = comicTitle;
    }
}

class Program
{
    static void Main()
    {
        List<Superhero> superheroes = new List<Superhero>
        {
            new Superhero("Captain America", 1941, "Captain America Comics"),
            new Superhero("Spider-Man", 1962, "Amazing Fantasy"),
            new Superhero("Wonder Woman", 1941, "All Star Comics"),
            new Superhero("Batman", 1939, "Detective Comics"),
            new Superhero("Green Lantern", 1940, "All-American Comics")
        };

        // Імперативний підхід
        Console.WriteLine("=== Імперативний підхід ===");

        // 1. Вивести імена супергероїв, які народилися 1941 р.
        Console.WriteLine("Супергерої, які народилися в 1941 році:");
        foreach (var hero in superheroes)
        {
            if (hero.BirthYear == 1941)
            {
                Console.WriteLine(hero.Name);
            }
        }

        // 2. Вивести назви коміксів і відсортувати їх в алфавітному порядку
        Console.WriteLine("\nНазви коміксів у алфавітному порядку:");
        List<string> comicTitles = new List<string>();
        foreach (var hero in superheroes)
        {
            comicTitles.Add(hero.ComicTitle);
        }
        comicTitles.Sort();
        foreach (var title in comicTitles)
        {
            Console.WriteLine(title);
        }

        // 3. Вивести імена супергероїв та дати їх народження і відсортувати їх в порядку спадання дат їх народження.
        Console.WriteLine("\nСупергерої та їх дати народження (в порядку спадання):");
        superheroes.Sort((a, b) => b.BirthYear.CompareTo(a.BirthYear));
        foreach (var hero in superheroes)
        {
            Console.WriteLine($"{hero.Name} - {hero.BirthYear}");
        }

        // Декларативний підхід
        Console.WriteLine("\n=== Декларативний підхід ===");

        // 1. Вивести імена супергероїв, які народилися 1941 р.
        var heroesBornIn1941 = superheroes
            .Where(hero => hero.BirthYear == 1941)
            .Select(hero => hero.Name);

        Console.WriteLine("Супергерої, які народилися в 1941 році:");
        foreach (var name in heroesBornIn1941)
        {
            Console.WriteLine(name);
        }

        // 2. Вивести назви коміксів і відсортувати їх в алфавітному порядку
        var sortedComicTitles = superheroes
            .Select(hero => hero.ComicTitle)
            .OrderBy(title => title);

        Console.WriteLine("\nНазви коміксів у алфавітному порядку:");
        foreach (var title in sortedComicTitles)
        {
            Console.WriteLine(title);
        }

        // 3. Вивести імена супергероїв та дати їх народження і відсортувати їх в порядку спадання дат їх народження.
        var sortedHeroes = superheroes
            .OrderByDescending(hero => hero.BirthYear)
            .Select(hero => new { hero.Name, hero.BirthYear });

        Console.WriteLine("\nСупергерої та їх дати народження (в порядку спадання):");
        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine($"{hero.Name} - {hero.BirthYear}");
        }
    }
}
