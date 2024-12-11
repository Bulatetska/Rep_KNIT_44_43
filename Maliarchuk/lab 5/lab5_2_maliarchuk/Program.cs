using System;

class Student
{
    private string _surname;
    private int _course;
    private string _studentID;

    public Student(string surname, int course, string studentID)
    {
        _surname = surname;
        _course = course;
        _studentID = studentID;
    }

    public string Surname { get => _surname; set => _surname = value; }
    public int Course { get => _course; set => _course = value; }
    public string StudentID { get => _studentID; set => _studentID = value; }

    public virtual void Print()
    {
        Console.WriteLine($"Прізвище: {_surname}, Курс: {_course}, Номер залікової книги: {_studentID}");
    }
}

class Aspirant : Student
{
    private string _dissertationTopic;

    public Aspirant(string surname, int course, string studentID, string dissertationTopic)
        : base(surname, course, studentID)
    {
        _dissertationTopic = dissertationTopic;
    }

    public string DissertationTopic { get => _dissertationTopic; set => _dissertationTopic = value; }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Тема дисертації: {_dissertationTopic}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Іванов", 2, "12345");
        student.Print();
        var aspirant = new Aspirant("Петров", 3, "67890", "Штучний інтелект");
        aspirant.Print();
    }
}
