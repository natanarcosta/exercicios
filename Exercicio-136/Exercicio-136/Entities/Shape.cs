using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_136.Entities.Enums;

namespace Exercicio_136.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
