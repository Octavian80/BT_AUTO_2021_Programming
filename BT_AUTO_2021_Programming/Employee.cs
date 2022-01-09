using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Employee :Person
    {
        double salary;

        public Employee(string firstName, string lastName, string adress, string city, string country, double salary) : base(firstName, lastName, adress, city, country)
        {
            this.salary = salary;
        }
        public void SetSalary( double salary)
        {
            this.salary = salary;
        }

        public static void PrintPersonStatic(Employee p)
        {
            Console.WriteLine("Employee first name is {0} and last name is {1} with salary {2}", p.GetFirstName(), p.GetLastName(), p.salary);
        }
    }
}
