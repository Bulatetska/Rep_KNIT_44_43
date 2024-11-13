﻿using System;
using System.Collections.Generic;
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
        new Hero { Name = "Superman", YearOfBirth = 1938, Comics = "Action Comics" },
        new Hero { Name = "Batman", YearOfBirth = 1938, Comics = "Detective Comics" },
        new Hero { Name = "Captain America", YearOfBirth = 1941, Comics = "Captain America Comics" },
        new Hero { Name = "Ironman", YearOfBirth = 1963, Comics = "Tales of Suspense" },
        new Hero { Name = "Spiderman", YearOfBirth = 1963, Comics = "Amazing Fantasy" }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Завдання 1 (імперативний підхід):");
        HeroesBornIn1941_Imperative();

        Console.WriteLine("\nЗавдання 1 (декларативний підхід):");
        HeroesBornIn1941_Declarative();

        Console.WriteLine("\nЗавдання 2 (імперативний підхід):");
        ComicsSorted_Imperative();

        Console.WriteLine("\nЗавдання 2 (декларативний підхід):");
        ComicsSorted_Declarative();

        Console.WriteLine("\nЗавдання 3 (імперативний підхід):");
        HeroesSortedByBirthYearDescending_Imperative();

        Console.WriteLine("\nЗавдання 3 (декларативний підхід):");
        HeroesSortedByBirthYearDescending_Declarative();
    }

    // Завдання 1: Імперативний підхід
    static void HeroesBornIn1941_Imperative()
    {
        var heroesBornIn1941 = new List<string>();
        foreach (var hero in _heroes)
        {
            if (hero.YearOfBirth == 1941)
            {
                heroesBornIn1941.Add(hero.Name);
            }
        }
        foreach (var hero in heroesBornIn1941)
        {
            Console.WriteLine(hero);
        }
    }

    // Завдання 1: Декларативний підхід
    static void HeroesBornIn1941_Declarative()
    {
        var heroesBornIn1941 = _heroes
            .Where(hero => hero.YearOfBirth == 1941)
            .Select(hero => hero.Name);

        foreach (var hero in heroesBornIn1941)
        {
            Console.WriteLine(hero);
        }
    }

    // Завдання 2: Імперативний підхід
    static void ComicsSorted_Imperative()
    {
        var comics = new List<string>();
        foreach (var hero in _heroes)
        {
            comics.Add(hero.Comics);
        }
        comics.Sort();
        foreach (var comic in comics)
        {
            Console.WriteLine(comic);
        }
    }

    // Завдання 2: Декларативний підхід
    static void ComicsSorted_Declarative()
    {
        var comics = _heroes
            .Select(hero => hero.Comics)
            .OrderBy(comic => comic);

        foreach (var comic in comics)
        {
            Console.WriteLine(comic);
        }
    }

    // Завдання 3: Імперативний підхід
    static void HeroesSortedByBirthYearDescending_Imperative()
    {
        var heroesList = new List<Hero>(_heroes);
        heroesList.Sort((hero1, hero2) => hero2.YearOfBirth.CompareTo(hero1.YearOfBirth));

        foreach (var hero in heroesList)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }
    }

    // Завдання 3: Декларативний підхід
    static void HeroesSortedByBirthYearDescending_Declarative()
    {
        var heroesSorted = _heroes
            .OrderByDescending(hero => hero.YearOfBirth)
            .Select(hero => new { hero.Name, hero.YearOfBirth });

        foreach (var hero in heroesSorted)
        {
            Console.WriteLine($"{hero.Name} - {hero.YearOfBirth}");
        }
    }
}
