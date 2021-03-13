using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_136.Entities.Enums;

namespace Exercicio_136.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(double width, double height, Color color) : base (color)
        {
            Width = width;
            Heigth = height;
            Color = color;
        }
        public override double Area()
        {
            return Width * Heigth;
        }
    }
}
