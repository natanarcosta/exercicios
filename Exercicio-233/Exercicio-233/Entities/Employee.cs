using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_233.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
