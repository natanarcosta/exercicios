using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_137.Entities;

namespace Exercicio_137
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos contribuintes? ");
            int n = int.Parse(Console.ReadLine());
            List<Contribuintes> lista = new List<Contribuintes>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}:");
                Console.Write("Pessoa Física ou Juridica (f/j) ? ");
                char tipoDePessoa = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: $");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipoDePessoa == 'f')
                {
                    Console.Write("Gastos com saúde: $");
                    double gasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, renda, gasto));
                } else
                {
                    Console.Write("Número de funcionários da empresa: ");
                    int func = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, renda, func));
                }
            }
            foreach(Contribuintes pessoa in lista)
            {
                Console.WriteLine(pessoa.Name + ": $ " + pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
