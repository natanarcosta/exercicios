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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(Partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao Origem = Tela.LerPosicaoXadrez().toPosicao();
                        Partida.ValidarOrigem(Origem);

                        bool[,] PosicoesPossiveis = Partida.Tab.Peca(Origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.ImprimirTabuleiro(Partida.Tab, PosicoesPossiveis);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + Partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + Partida.JogadorAtual);
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao Destino = Tela.LerPosicaoXadrez().toPosicao();
                        Partida.ValidarDestino(Origem, Destino);

                        Partida.RealizaJogada(Origem, Destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(Partida);
             
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
