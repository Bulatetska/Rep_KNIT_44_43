using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    // Define the Course class
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DurationInHours { get; set; } // Duration of the course in hours
    }

    // Define the Student class
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> EnrolledCourses { get; set; } // List of courses the student is enrolled in
    }

    class Program
    {
        // Sample data for courses
        private static List<Course> courses = new List<Course>
        {
            new Course { ID = 1, Name = "Mathematics", DurationInHours = 40 },
            new Course { ID = 2, Name = "Physics", DurationInHours = 30 },
            new Course { ID = 3, Name = "Chemistry", DurationInHours = 50 }
        };

        // Sample data for students
        private static List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice", Age = 22, EnrolledCourses = new List<Course> { courses[0], courses[1] } },
            new Student { ID = 2, Name = "Bob", Age = 19, EnrolledCourses = new List<Course> { courses[1] } },
            new Student { ID = 3, Name = "Charlie", Age = 23, EnrolledCourses = new List<Course> { courses[0], courses[2] } },
            new Student { ID = 4, Name = "Diana", Age = 21, EnrolledCourses = new List<Course> { courses[0] } },
            new Student { ID = 5, Name = "Evan", Age = 17, EnrolledCourses = new List<Course> { courses[2] } }
        };

        static void Main(string[] args)
        {
            // 1. Find all students older than 20
            var studentsOver20 = students.Where(student => student.Age > 20);
            Console.WriteLine("Students older than 20:");
            foreach (var student in studentsOver20)
            {
                Console.WriteLine(student.Name);
            }

            // 2. Output names of students enrolled in a specific course (e.g., "Mathematics")
            var studentsInMath = students.Where(student => student.EnrolledCourses.Any(course => course.Name == "Mathematics"))
                                          .Select(student => student.Name);
            Console.WriteLine("\nStudents enrolled in Mathematics:");
            foreach (var name in studentsInMath)
            {
                Console.WriteLine(name);
            }

            // 3. Count the number of courses each student is enrolled in
            var studentCourseCounts = students.Select(student => new
            {
                student.Name,
                CourseCount = student.EnrolledCourses.Count
            });
            Console.WriteLine("\nNumber of courses each student is enrolled in:");
            foreach (var student in studentCourseCounts)
            {
                Console.WriteLine($"{student.Name}: {student.CourseCount}");
            }

            // 4. Sort students by the number of courses they are enrolled in
            var sortedStudentsByCourseCount = students.OrderByDescending(student => student.EnrolledCourses.Count);
            Console.WriteLine("\nStudents sorted by the number of courses:");
            foreach (var student in sortedStudentsByCourseCount)
            {
                Console.WriteLine($"{student.Name}: {student.EnrolledCourses.Count}");
            }

            // Additional Task 1: Find students whose names start with a specific letter (e.g., "A") and sort by age descending
            var studentsStartingWithA = students.Where(student => student.Name.StartsWith("A"))
                                                 .OrderByDescending(student => student.Age);
            Console.WriteLine("\nStudents whose names start with 'A' sorted by age descending:");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine($"{student.Name}, Age: {student.Age}");
            }

            // Additional Task 2: Combine both lists and output student names with their enrolled course names
            var studentCourseEnrollments = from student in students
                                           from course in student.EnrolledCourses
                                           select new
                                           {
                                               StudentName = student.Name,
                                               CourseName = course.Name
                                           };
            Console.WriteLine("\nStudent enrollments:");
            foreach (var enrollment in studentCourseEnrollments)
            {
                Console.WriteLine($"Student {enrollment.StudentName} is enrolled in course {enrollment.CourseName}");
            }

            // Additional Task 3: Group students by age category
            var ageGroups = students.GroupBy(student =>
            {
                if (student.Age < 18) return "Younger than 18";
                else if (student.Age >= 18 && student.Age <= 22) return "18 to 22";
                else return "Older than 22";
            }).Select(group => new
            {
                AgeCategory = group.Key,
                StudentCount = group.Count()
            });
            Console.WriteLine("\nAge categories of students:");
            foreach (var group in ageGroups)
            {
                Console.WriteLine($"{group.AgeCategory}: {group.StudentCount}");
            }

            // Additional Task 4: Create a course list with duration and perform LINQ queries
            var courseDurations = courses.Select(course => new
            {
                course.Name,
                course.DurationInHours
            }).ToList();

            // Sum of hours for all courses
            var totalDuration = courseDurations.Sum(course => course.DurationInHours);
            Console.WriteLine($"\nTotal hours for all courses: {totalDuration}");

            // Average duration of courses
            var averageDuration = courseDurations.Average(course => course.DurationInHours);
            Console.WriteLine($"Average duration of courses: {averageDuration}");

            // Course with maximum duration
            var maxDurationCourse = courseDurations.OrderByDescending(course => course.DurationInHours).First();
            Console.WriteLine($"Course with maximum duration: {maxDurationCourse.Name}, Duration: {maxDurationCourse.DurationInHours}");

            // Additional Task 5: Transform students list to anonymous structure with names and course counts
            var studentSummary = students.Select(student => new
            {
                student.Name,
                CourseCount = student.EnrolledCourses.Count
            });
            Console.WriteLine("\nStudent names and course counts:");
            foreach (var summary in studentSummary)
            {
                Console.WriteLine($"{summary.Name}: {summary.CourseCount}");
            }

            // Prevent console from closing immediately
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
