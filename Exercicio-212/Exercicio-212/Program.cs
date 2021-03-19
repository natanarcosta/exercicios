using System;
using System.Collections.Generic;

namespace Exercicio_212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            HashSet<int> students = new HashSet<int>();
            AddStudents(a, students);
            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            AddStudents(b, students);
            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            AddStudents(c, students);

            Console.WriteLine("Total students: " + students.Count);
        }
        static void AddStudents(int quantity, HashSet<int> set)
        {
            for(int i = 0; i < quantity; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(id);
            }
        }
    }
}
