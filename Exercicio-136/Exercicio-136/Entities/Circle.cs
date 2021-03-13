using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_136.Entities.Enums;

namespace Exercicio_136.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return 3.14 * (Radius*Radius);
        }
    }
}
