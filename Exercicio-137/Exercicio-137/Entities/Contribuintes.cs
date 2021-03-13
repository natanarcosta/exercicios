using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_137.Entities
{
    abstract class Contribuintes
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Contribuintes(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
