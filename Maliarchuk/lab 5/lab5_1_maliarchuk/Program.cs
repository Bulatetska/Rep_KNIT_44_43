using System;

class Person
{
    private string _name;
    private int _age;
    private string _gender;
    private string _phoneNumber;

    public Person(string name, int age, string gender, string phoneNumber)
    {
        _name = name;
        _age = age;
        _gender = gender;
        _phoneNumber = phoneNumber;
    }

    public string Name { get => _name; set => _name = value; }
    public int Age { get => _age; set => _age = value; }
    public string Gender { get => _gender; set => _gender = value; }
    public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

    public void Print()
    {
        Console.WriteLine($"Ім'я: {_name}, Вік: {_age}, Стать: {_gender}, Телефон: {_phoneNumber}");
    }
}

class Program
{
    static void Main()
    {
        var person = new Person("Анна", 30, "Жінка", "098-123-4567");

        Console.WriteLine("Інформація про людину:");
        person.Print();

        person.Name = "Іван";
        person.Age = 35;
        person.Gender = "Чоловік";
        person.PhoneNumber = "097-765-4321";

        Console.WriteLine("\nІнформація після змін:");
        person.Print();
    }
}
