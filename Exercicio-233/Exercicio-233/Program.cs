using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Exercicio_233.Entities;

namespace Exercicio_233
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\employees.csv";
            List<Employee> list = new List<Employee>();

            using (StreamReader arquivo = new StreamReader(path))
            {
                while (!(arquivo.EndOfStream))
                {
                    string[] fields = arquivo.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }

                Console.Write("Salary: $");
                double teto = double.Parse(Console.ReadLine());
                Console.WriteLine($"Email of people whose salary is more than {teto} :");
                var emails = from e in list where e.Salary > teto orderby e.Name select e.Email;
                foreach(string email in emails)
                {
                    Console.WriteLine(email);
                }

                var sum = list.Where(s => s.Name[0] == 'M').Sum(s => s.Salary);

                Console.Write("Sum of salary of people whose name starts with 'M' : " + sum.ToString("F2", CultureInfo.InvariantCulture));
              
            }
        }
    }
}
