using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_136.Entities.Enums;
using Exercicio_136.Entities;

namespace Exercicio_136
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();

            for ( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} date:");
                Console.Write("Rectangle or circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                } else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
                foreach(Shape x in list)
                {
                    Console.WriteLine(x.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
