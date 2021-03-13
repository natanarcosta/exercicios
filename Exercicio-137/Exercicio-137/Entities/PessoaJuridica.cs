using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_137.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string name, double renda, int funcionarios) : base(name, renda)
        {
            Funcionarios = funcionarios;
        }
        public override double Imposto()
        {
            if(Funcionarios > 10)
            {
                return RendaAnual * 0.14;
            } else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
