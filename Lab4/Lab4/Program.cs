using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTasks
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public int DurationHours { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Список курсів
            var courses = new List<Course>
            {
                new Course { ID = 1, CourseName = "Математика", DurationHours = 40 },
                new Course { ID = 2, CourseName = "Фізика", DurationHours = 30 },
                new Course { ID = 3, CourseName = "Хімія", DurationHours = 35 }
            };

            // Список студентів
            var students = new List<Student>
            {
                new Student { ID = 1, Name = "Анна", Age = 21, Courses = new List<Course> { courses[0], courses[1] } },
                new Student { ID = 2, Name = "Іван", Age = 19, Courses = new List<Course> { courses[0] } },
                new Student { ID = 3, Name = "Олег", Age = 23, Courses = new List<Course> { courses[1], courses[2] } },
                new Student { ID = 4, Name = "Андрій", Age = 25, Courses = new List<Course> { courses[2] } },
                new Student { ID = 5, Name = "Марія", Age = 20, Courses = new List<Course> { courses[0], courses[2] } }
            };

            // Знайдіть усіх студентів, яким більше 20 років.
            var studentsOlderThan20 = students.Where(s => s.Age > 20);
            Console.WriteLine("Студенти старші за 20 років:");
            foreach (var student in studentsOlderThan20)
            {
                Console.WriteLine(student.Name);
            }

            // Виведіть імена студентів, які записані на певний курс (наприклад, "Математика").
            string courseName = "Математика";
            var studentsInCourse = students.Where(s => s.Courses.Any(c => c.CourseName == courseName))
                                           .Select(s => s.Name);
            Console.WriteLine($"\nСтуденти, які записані на курс {courseName}:");
            foreach (var name in studentsInCourse)
            {
                Console.WriteLine(name);
            }

            // Підрахуйте кількість курсів, на які записаний кожен студент.
            var studentCourseCounts = students.Select(s => new { s.Name, CourseCount = s.Courses.Count });
            Console.WriteLine("\nКількість курсів для кожного студента:");
            foreach (var student in studentCourseCounts)
            {
                Console.WriteLine($"{student.Name} - {student.CourseCount} курсів");
            }

            // Відсортуйте студентів за кількістю курсів, на які вони записані.
            var studentsSortedByCourseCount = students.OrderByDescending(s => s.Courses.Count);
            Console.WriteLine("\nСтуденти, відсортовані за кількістю курсів:");
            foreach (var student in studentsSortedByCourseCount)
            {
                Console.WriteLine($"{student.Name} - {student.Courses.Count} курсів");
            }

            // Знайдіть усіх студентів, чиї імена починаються з певної літери (наприклад, "А"). Відсортуйте цих студентів за віком у порядку спадання.
            char initial = 'А';
            var studentsStartingWithA = students.Where(s => s.Name.StartsWith(initial))
                                                .OrderByDescending(s => s.Age);
            Console.WriteLine($"\nСтуденти, імена яких починаються з '{initial}', відсортовані за віком:");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine($"{student.Name} - {student.Age} років");
            }

            // Об'єднайте обидва списки та виведіть імена студентів разом з назвами курсів, на які вони записані.
            Console.WriteLine("\nСписок студентів та їхніх курсів:");
            var studentCourseList = students.SelectMany(s => s.Courses, (s, c) => new { StudentName = s.Name, CourseName = c.CourseName });
            foreach (var entry in studentCourseList)
            {
                Console.WriteLine($"Студент {entry.StudentName} записаний на курс {entry.CourseName}");
            }

            // Згрупуйте студентів за їхньою віковою категорією.
            var studentAgeGroups = students.GroupBy(s =>
            {
                if (s.Age < 18) return "Молодший за 18";
                else if (s.Age <= 22) return "Від 18 до 22";
                else return "Старший за 22";
            });
            Console.WriteLine("\nГрупи студентів за віковими категоріями:");
            foreach (var group in studentAgeGroups)
            {
                Console.WriteLine($"{group.Key}: {group.Count()} студентів");
            }

            // Сумарна кількість годин для всіх курсів, середня тривалість курсу, курс із максимальною тривалістю.
            int totalHours = courses.Sum(c => c.DurationHours);
            double averageDuration = courses.Average(c => c.DurationHours);
            var longestCourse = courses.OrderByDescending(c => c.DurationHours).First();
            Console.WriteLine("\nІнформація про тривалість курсів:");
            Console.WriteLine($"Сумарна кількість годин: {totalHours}");
            Console.WriteLine($"Середня тривалість курсу: {averageDuration} годин");
            Console.WriteLine($"Курс із максимальною тривалістю: {longestCourse.CourseName} ({longestCourse.DurationHours} годин)");

            // Створіть список анонімних об'єктів із іменами студентів та кількістю курсів, на які вони записані.
            var studentCourseSummary = students.Select(s => new { s.Name, CourseCount = s.Courses.Count });
            Console.WriteLine("\nІмена студентів та кількість курсів:");
            foreach (var student in studentCourseSummary)
            {
                Console.WriteLine($"{student.Name} - {student.CourseCount} курсів");
            }
        }
    }
}
