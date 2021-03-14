using System;
using tabuleiro;
using xadrez;

namespace JogoDeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez Partida = new PartidaDeXadrez();

                while (!Partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao Origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] PosicoesPossiveis = Partida.Tab.Peca(Origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab, PosicoesPossiveis);
                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao Destino = Tela.LerPosicaoXadrez().toPosicao();

                    Partida.ExecutaMovimento(Origem, Destino);

                }
             
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
