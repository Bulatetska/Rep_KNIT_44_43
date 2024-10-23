using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    // Student class
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } // List of courses the student is enrolled in
    }

    // Course class
    class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public int DurationInHours { get; set; } // Duration of the course in hours
    }

    internal class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice", Age = 19, Courses = new List<Course> { new Course { ID = 1, CourseName = "Math", DurationInHours = 30 } } },
            new Student { ID = 2, Name = "Bob", Age = 22, Courses = new List<Course> { new Course { ID = 1, CourseName = "Math", DurationInHours = 30 }, new Course { ID = 2, CourseName = "English", DurationInHours = 40 } } },
            new Student { ID = 3, Name = "Charlie", Age = 21, Courses = new List<Course> { new Course { ID = 2, CourseName = "English", DurationInHours = 40 } } },
            new Student { ID = 4, Name = "David", Age = 23, Courses = new List<Course> { new Course { ID = 3, CourseName = "History", DurationInHours = 25 } } },
            new Student { ID = 5, Name = "Ann", Age = 18, Courses = new List<Course> { new Course { ID = 3, CourseName = "History", DurationInHours = 25 }, new Course { ID = 1, CourseName = "Math", DurationInHours = 30 } } }
        };

        static List<Course> courses = new List<Course>
        {
            new Course { ID = 1, CourseName = "Math", DurationInHours = 30 },
            new Course { ID = 2, CourseName = "English", DurationInHours = 40 },
            new Course { ID = 3, CourseName = "History", DurationInHours = 25 }
        };

        static void Main(string[] args)
        {
            // Task 1: Find all students older than 20
            var studentsOlderThan20 = students.Where(s => s.Age > 20).ToList();
            Console.WriteLine("Students older than 20:");
            foreach (var student in studentsOlderThan20)
            {
                Console.WriteLine(student.Name);
            }

            // Task 2: Show the names of students enrolled in a specific course (e.g., "Math")
            string specificCourse = "Math";
            var studentsInMath = students.Where(s => s.Courses.Any(c => c.CourseName == specificCourse)).Select(s => s.Name).ToList();
            Console.WriteLine($"\nStudents enrolled in {specificCourse}:");
            foreach (var student in studentsInMath)
            {
                Console.WriteLine(student);
            }

            // Task 3: Count the number of courses each student is enrolled in
            var studentCourseCount = students.Select(s => new { s.Name, CourseCount = s.Courses.Count }).ToList();
            Console.WriteLine("\nNumber of courses each student is enrolled in:");
            foreach (var student in studentCourseCount)
            {
                Console.WriteLine($"{student.Name} is enrolled in {student.CourseCount} course(s).");
            }

            // Task 4: Sort students by the number of courses they are enrolled in
            var sortedStudentsByCourses = students.OrderByDescending(s => s.Courses.Count).ToList();
            Console.WriteLine("\nStudents sorted by the number of courses they are enrolled in:");
            foreach (var student in sortedStudentsByCourses)
            {
                Console.WriteLine($"{student.Name} is enrolled in {student.Courses.Count} course(s).");
            }

            // Additional Task 1: Find all students whose names start with a specific letter (e.g., "A") and sort them by age in descending order
            char initialLetter = 'A';
            var studentsStartingWithA = students.Where(s => s.Name.StartsWith(initialLetter.ToString())).OrderByDescending(s => s.Age).ToList();
            Console.WriteLine($"\nStudents whose names start with '{initialLetter}', sorted by age:");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine($"{student.Name} - Age {student.Age}");
            }

            // Additional Task 2: Join both lists and display the student names along with the courses they are enrolled in
            var studentCourseJoin = students.SelectMany(s => s.Courses, (s, c) => new { s.Name, c.CourseName }).ToList();
            Console.WriteLine("\nStudent names and their enrolled courses:");
            foreach (var entry in studentCourseJoin)
            {
                Console.WriteLine($"Student {entry.Name} is enrolled in course {entry.CourseName}");
            }

            // Additional Task 3: Group students by age category (Under 18, 18-22, Over 22)
            var groupedByAgeCategory = students.GroupBy(s => s.Age < 18 ? "Under 18" :
                                                              s.Age <= 22 ? "18-22" : "Over 22")
                                               .Select(g => new { AgeCategory = g.Key, Count = g.Count() }).ToList();
            Console.WriteLine("\nStudents grouped by age category:");
            foreach (var group in groupedByAgeCategory)
            {
                Console.WriteLine($"{group.AgeCategory}: {group.Count} student(s)");
            }

            // Additional Task 4: Find the total number of hours for all courses, average course duration, and the course with the maximum duration
            var totalHours = courses.Sum(c => c.DurationInHours);
            var averageDuration = courses.Average(c => c.DurationInHours);
            var maxDurationCourse = courses.OrderByDescending(c => c.DurationInHours).First();

            Console.WriteLine($"\nTotal number of hours for all courses: {totalHours}");
            Console.WriteLine($"Average course duration: {averageDuration} hours");
            Console.WriteLine($"Course with the maximum duration: {maxDurationCourse.CourseName} ({maxDurationCourse.DurationInHours} hours)");

            // Additional Task 5: Transform the list of students into a new anonymous structure with student names and the number of courses they are enrolled in
            var transformedStudentList = students.Select(s => new { s.Name, CourseCount = s.Courses.Count }).ToList();
            Console.WriteLine("\nTransformed student list with names and number of enrolled courses:");
            foreach (var student in transformedStudentList)
            {
                Console.WriteLine($"{student.Name} is enrolled in {student.CourseCount} course(s).");
            }
        }
    }
}
