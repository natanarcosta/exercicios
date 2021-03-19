using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio_214
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";
            Dictionary<string, int> apuracao = new Dictionary<string, int>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] candidato = sr.ReadLine().Split(',');
                    string nome = candidato[0];
                    int votos = int.Parse(candidato[1]);
                    if (apuracao.ContainsKey(nome))
                    {
                        int temp = apuracao[nome];
                        apuracao.Remove(nome);
                        apuracao.Add(nome, temp + votos);
                    }
                    else
                    {
                        apuracao.Add(nome, votos);
                    }
                }
                foreach (var x in apuracao)
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}
