using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Student
    {
        public string FirstName { get; set; }
        public int Course { get; set; }
        public int ExamNumber { get; set; }

        public Student(string firstName, int course, int examNumber)
        {
            this.FirstName = firstName;
            this.Course = course;
            this.ExamNumber = examNumber;
        }
    }

    public class Aspirant : Student
    {
        public string ResearchTopic { get; set; }

        public Aspirant(string firstName, int course, int examNumber, string ResearchTopic) : base(firstName, course, examNumber)
        {
            this.ResearchTopic = ResearchTopic;
        }

        public void Print()
        {
            Console.WriteLine("Student " + this.FirstName + " that studying at " + this.Course + " and have an " + this.ExamNumber + " record number, defends the subject: " + this.ResearchTopic);
        }
    }
}
