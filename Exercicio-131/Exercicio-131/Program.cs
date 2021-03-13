using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_131.Entities;

namespace Exercicio_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for ( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char isOutsorced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: $");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (isOutsorced == 'y')
                {
                    Console.Write("Additional charge: $");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutsourcedEmployee OEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    list.Add(OEmployee);
                } else if (isOutsorced == 'n')
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    list.Add(employee);
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee x in list)
            {
                Console.WriteLine(x.Name + " - $ " + x.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
