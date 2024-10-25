using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentCourseExample
{
    // Створюємо клас Student
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
    }

    // Створюємо клас Course
    class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public int DurationInHours { get; set; }
        

    class Program
    {
        static void Main(string[] args)
        {
            // Створення списків студентів і курсів
            var courses = new List<Course>
            {
                new Course { ID = 1, CourseName = "Математика",  DurationInHours = 40 },
                new Course { ID = 2, CourseName = "Програмування" ,  DurationInHours = 50},
                new Course { ID = 3, CourseName = "Англійська мова",  DurationInHours = 65}
            };

            var students = new List<Student>
            {
                new Student { ID = 1, Name = "Павло", Age = 19, Courses = new List<Course> { courses[0], courses[1] } },
                new Student { ID = 2, Name = "Надія", Age = 21, Courses = new List<Course> { courses[1], courses[2] } },
                new Student { ID = 3, Name = "Діана", Age = 20, Courses = new List<Course> { courses[0], courses[2] } },
                new Student { ID = 4, Name = "Ігор", Age = 21, Courses = new List<Course> { courses[0] } },
                new Student { ID = 5, Name = "Максим", Age = 20, Courses = new List<Course> { courses[1], courses[2] } }
            };

            // Завдання 1: Знайти усіх студентів, яким більше 20 років
            var studentsAbove20 = students
            .Where(s => s.Age > 20)
            .ToList();
            Console.WriteLine("Студенти старше 20 років:");
            foreach (var student in studentsAbove20)
            {
                Console.WriteLine(student.Name);
            }

            // Завдання 2: Вивести імена студентів, які записані на курс "Математика"
            var mathStudents = students
            .Where(s => s.Courses.Any(c => c.CourseName == "Математика"))
            .ToList();
            Console.WriteLine("\nСтуденти, записані на курс Математика:");
            foreach (var student in mathStudents)
            {
                Console.WriteLine(student.Name);
            }

            // Завдання 3: Підрахувати кількість курсів, на які записаний кожен студент
            Console.WriteLine("\nКількість курсів у кожного студента:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Courses.Count} курс(и)");
            }

            // Завдання 4: Відсортувати студентів за кількістю курсів
            var sortedByCourseCount = students
            .OrderByDescending(s => s.Courses.Count)
            .ToList();
            Console.WriteLine("\nСтуденти, відсортовані за кількістю курсів:");
            foreach (var student in sortedByCourseCount)
            {
                Console.WriteLine($"{student.Name}: {student.Courses.Count} курс(и)");
            }

            // Додаткове 1: Знайти всіх студентів, чиї імена починаються з "А", і відсортувати за віком у порядку спадання
            var aStudents = students
            .Where(s => s.Name.StartsWith("А"))
            .OrderByDescending(s => s.Age)
            .ToList();
            Console.WriteLine("\nСтуденти з іменами, що починаються на 'А':");
            foreach (var student in aStudents)
            {
                Console.WriteLine($"{student.Name} - Вік: {student.Age}");
            }

            // Додаткове 2: Об'єднати списки студентів і курсів у форматі "Студент [Ім'я] записаний на курс [Назва курсу]"
            Console.WriteLine("\nСтуденти та їхні курси:");
            var studentCourses = students
            .SelectMany(s => s.Courses
            .Select(c => new { StudentName = s.Name, CourseName = c.CourseName }));
            foreach (var item in studentCourses)
            {
                Console.WriteLine($"Студент {item.StudentName} записаний на курс {item.CourseName}");
            }

            // Додаткове 3: Групувати студентів за віковою категорією
            var groupedByAgeCategory = students
            .GroupBy(s =>
                s.Age < 18 ? "Молодше 18" :
                s.Age <= 22 ? "Від 18 до 22" :
                "Старше 22")
                .ToList();
            Console.WriteLine("\nСтуденти за віковими категоріями:");
            foreach (var group in groupedByAgeCategory)
            {
                Console.WriteLine($"{group.Key}: {group.Count()} студента(ів)");
            }

            // Додаткове 4: Знайти сумарну, середню та максимальну тривалість курсу
            var totalDuration = courses.Sum(c => c.DurationInHours);
            var averageDuration = courses.Average(c => c.DurationInHours);
            var maxDurationCourse = courses.OrderByDescending(c => c.DurationInHours).First();
            Console.WriteLine($"\nСумарна тривалість всіх курсів: {totalDuration} годин");
            Console.WriteLine($"Середня тривалість курсу: {averageDuration} годин");
            Console.WriteLine($"Курс з максимальною тривалістю: {maxDurationCourse.CourseName} ({maxDurationCourse.DurationInHours} годин)");

            // Додаткове 5: Створити новий список із іменами студентів та кількістю курсів
            var studentCourseCounts = students.Select(s => new { s.Name, CourseCount = s.Courses.Count }).ToList();
            Console.WriteLine("\nСтуденти та кількість курсів:");
            foreach (var item in studentCourseCounts)
            {
                Console.WriteLine($"{item.Name} - Кількість курсів: {item.CourseCount}");
            }
        }
    }
}
}
