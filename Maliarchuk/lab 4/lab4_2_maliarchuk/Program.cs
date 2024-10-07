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

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public int Course
    {
        get { return _course; }
        set { _course = value; }
    }

    public string StudentID
    {
        get { return _studentID; }
        set { _studentID = value; }
    }

    public virtual void Print()
    {
        Console.WriteLine("Прізвище: " + _surname);
        Console.WriteLine("Курс: " + _course);
        Console.WriteLine("Номер залікової книги: " + _studentID);
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

    public string DissertationTopic
    {
        get { return _dissertationTopic; }
        set { _dissertationTopic = value; }
    }

    public override void Print()
    {
        base.Print(); 
        Console.WriteLine("Тема дисертації: " + _dissertationTopic);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Іванов", 2, "12345");
        Console.WriteLine("Інформація про студента:");
        student.Print();

        Aspirant aspirant = new Aspirant("Петров", 3, "67890", "Нові методи машинного навчання");
        Console.WriteLine("\nІнформація про аспіранта:");
        aspirant.Print();
    }
}
