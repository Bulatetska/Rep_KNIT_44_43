using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Person
    {
        private string name;
        private int age;
        private string gender;
        private string phoneNumber;

        public void changeName(string name)
        {
            this.name = name;
        }

        public void changeAge(int age)
        {
            this.age = age;
        }

        public void changeGender(string gender)
        {
            this.gender = gender;
        }
        public void changePhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void Print()
        {
            Console.WriteLine(this.name + " " + this.age + " " + this.gender + " " + this.phoneNumber);
        }
    }
}
