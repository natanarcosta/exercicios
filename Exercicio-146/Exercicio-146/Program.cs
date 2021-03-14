using System;
using System.Globalization;
using Exercicio_146.Entities.Exceptions;
using Exercicio_146.Entities;

namespace Exercicio_146
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dados da conta:");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Depósito Inicial: $");
                double inicial = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: $");
                double limiteDeSaque = double.Parse(Console.ReadLine());

                Account conta = new Account(numero, titular, inicial, limiteDeSaque);

                Console.Write("Valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Withdraw(saque);
                Console.Write("Novo saldo: " + conta.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro!" + e.Message);
            }
        }
    }
}
