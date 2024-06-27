using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_06_2024_Hometask
{
    public class Employee : IPerson
    {
        private static int idCounter = 0;
        private int id;
        public int Id => id;

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            if (string.IsNullOrWhiteSpace(name) || age <= 0 || salary <= 0)
            {
                throw new ArgumentException("Name, age, and salary must be provided and valid.");
            }
            id = ++idCounter;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public string ShowInfo()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }


}
