using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_137.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string name, double renda, double gastosaude) : base(name, renda)
        {
            GastoSaude = gastosaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000)
            {
                return (RendaAnual * 0.15) - (GastoSaude * 0.5);
            } else
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.5);
            }
        }
    }
}
