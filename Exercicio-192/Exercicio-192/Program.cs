using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_192
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\natan\Desktop\C#\Exercicios\Exercicio-192\source\itens.csv";
            string targetPath = @"C:\Users\natan\Desktop\C#\Exercicios\Exercicio-192\source\out\summary.csv";

            try
            {
                using (StreamReader reader = File.OpenText(sourcePath))
                {
                    using (StreamWriter writer = File.AppendText(targetPath))
                    {

                        string[] csvLines = File.ReadAllLines(sourcePath);



                        for (int i = 0; i < csvLines.Length; i++)
                        {
                            string itemName = csvLines[i].Split(',')[0];
                            double itemPrice = double.Parse(csvLines[i].Split(',')[1], CultureInfo.InvariantCulture);
                            double quantity = int.Parse(csvLines[i].Split(',')[2], CultureInfo.InvariantCulture);
                            double total = itemPrice * quantity;
                            string summary = itemName + "," + total.ToString("F2", CultureInfo.InvariantCulture);
                            writer.WriteLine(summary);
                            Console.WriteLine("Escrito " + summary);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
