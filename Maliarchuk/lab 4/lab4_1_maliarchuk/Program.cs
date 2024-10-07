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

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public void SetGender(string gender)
    {
        _gender = gender;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        _phoneNumber = phoneNumber;
    }

    public void Print()
    {
        Console.WriteLine("Ім'я: " + _name);
        Console.WriteLine("Вік: " + _age);
        Console.WriteLine("Стать: " + _gender);
        Console.WriteLine("Телефонний номер: " + _phoneNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Олексій", 25, "Чоловік", "098-123-4567");

        person.Print();

        person.SetName("Анна");
        person.SetAge(30);
        person.SetGender("Жінка");
        person.SetPhoneNumber("097-765-4321");

        Console.WriteLine("\nДані після змін:");
        person.Print();
    }
}
