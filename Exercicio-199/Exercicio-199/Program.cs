using System;
using System.Globalization;
using Exercicio_199.Entities;
using Exercicio_199.Services;


namespace Exercicio_199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: $");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value, installments, new Paypal());
            contract.CreateInstallments();
            contract.PrintInstallments();
        }
    }
}
