using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Course> Courses { get; set; }

    public Student(int id, string name, int age, List<Course> courses)
    {
        ID = id;
        Name = name;
        Age = age;
        Courses = courses;
    }
}

public class Course
{
    public int ID { get; set; }
    public string CourseName { get; set; }
    public int DurationInHours { get; set; } // Тривалість у годинах

    public Course(int id, string courseName, int durationInHours)
    {
        ID = id;
        CourseName = courseName;
        DurationInHours = durationInHours;
    }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Аліна", 19, new List<Course>()),
            new Student(2, "Олег", 21, new List<Course>()),
            new Student(3, "Ірина", 22, new List<Course>()),
            new Student(4, "Сергій", 23, new List<Course>()),
            new Student(5, "Діана", 17, new List<Course>())
        };

        List<Course> courses = new List<Course>
        {
            new Course(1, "Математика", 40),
            new Course(2, "Фізика", 30),
            new Course(3, "Хімія", 35)
        };

        // Додаємо курси студентам
        students[0].Courses.Add(courses[0]); // Аліна записана на Математику
        students[1].Courses.Add(courses[1]); // Олег записаний на Фізику
        students[1].Courses.Add(courses[2]); // Олег також записаний на Хімію
        students[2].Courses.Add(courses[0]); // Ірина записана на Математику
        students[3].Courses.Add(courses[1]); // Сергій записаний на Фізику
        students[3].Courses.Add(courses[2]); // Сергій також записаний на Хімію
        students[4].Courses.Add(courses[0]); // Діана записана на Математику

        // 1. Знайти усіх студентів, яким більше 20 років
        var studentsOver20 = students.Where(s => s.Age > 20).ToList();
        Console.WriteLine("Студенти старше 20 років:");
        foreach (var student in studentsOver20)
        {
            Console.WriteLine(student.Name);
        }

        // 2. Вивести імена студентів, які записані на певний курс (наприклад, "Математика").
        var studentsInMath = students.Where(s => s.Courses.Any(c => c.CourseName == "Математика"))
                                      .Select(s => s.Name)
                                      .ToList();
        Console.WriteLine("\nСтуденти, записані на Математику:");
        foreach (var student in studentsInMath)
        {
            Console.WriteLine(student);
        }

        // 3. Підрахувати кількість курсів, на які записаний кожен студент.
        var studentCourseCount = students.Select(s => new { s.Name, CourseCount = s.Courses.Count }).ToList();
        Console.WriteLine("\nКількість курсів для кожного студента:");
        foreach (var item in studentCourseCount)
        {
            Console.WriteLine($"{item.Name}: {item.CourseCount}");
        }

        // 4. Відсортувати студентів за кількістю курсів, на які вони записані.
        var sortedStudentsByCourseCount = students.OrderByDescending(s => s.Courses.Count).ToList();
        Console.WriteLine("\nСтуденти, відсортовані за кількістю курсів:");
        foreach (var student in sortedStudentsByCourseCount)
        {
            Console.WriteLine($"{student.Name} - {student.Courses.Count} курсів");
        }

        // Додаткові завдання:

        // 1. Знайти усіх студентів, чиї імена починаються з певної літери (наприклад, "А").
        var studentsStartingWithA = students.Where(s => s.Name.StartsWith("А"))
                                            .OrderByDescending(s => s.Age)
                                            .ToList();
        Console.WriteLine("\nСтуденти, чиї імена починаються з 'А':");
        foreach (var student in studentsStartingWithA)
        {
            Console.WriteLine(student.Name);
        }

        // 2. Об'єднати списки студентів і курсів
        var studentCourses = from student in students
                             from course in student.Courses
                             select new { student.Name, course.CourseName };

        Console.WriteLine("\nСтуденти та їх курси:");
        foreach (var item in studentCourses)
        {
            Console.WriteLine($"Студент {item.Name} записаний на курс {item.CourseName}");
        }

        // 3. Групувати студентів за віковими категоріями
        var ageCategories = new Dictionary<string, List<Student>>
        {
            { "Молодший за 18", new List<Student>() },
            { "Від 18 до 22", new List<Student>() },
            { "Старший за 22", new List<Student>() }
        };

        foreach (var student in students)
        {
            if (student.Age < 18)
                ageCategories["Молодший за 18"].Add(student);
            else if (student.Age >= 18 && student.Age <= 22)
                ageCategories["Від 18 до 22"].Add(student);
            else
                ageCategories["Старший за 22"].Add(student);
        }

        Console.WriteLine("\nВікові категорії студентів:");
        foreach (var category in ageCategories)
        {
            Console.WriteLine($"{category.Key}: {category.Value.Count} студентів");
        }

        // 4. Знайти сумарну кількість годин для всіх курсів та середню тривалість курсу
        var totalDuration = courses.Sum(c => c.DurationInHours);
        var averageDuration = courses.Average(c => c.DurationInHours);
        var maxDurationCourse = courses.OrderByDescending(c => c.DurationInHours).First();

        Console.WriteLine($"\nСумарна кількість годин для всіх курсів: {totalDuration} годин");
        Console.WriteLine($"Середня тривалість курсу: {averageDuration} годин");
        Console.WriteLine($"Курс з максимальною тривалістю: {maxDurationCourse.CourseName} - {maxDurationCourse.DurationInHours} годин");

        // 5. Перетворити список студентів у список нової анонімної структури
        var studentSummary = students.Select(s => new
        {
            Name = s.Name,
            CourseCount = s.Courses.Count
        }).ToList();

        Console.WriteLine("\nСписок студентів з кількістю курсів:");
        foreach (var item in studentSummary)
        {
            Console.WriteLine($"Студент {item.Name} записаний на {item.CourseCount} курсів");
        }
    }
}
