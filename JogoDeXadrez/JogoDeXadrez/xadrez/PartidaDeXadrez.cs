using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }


        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }
        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQntMovimentos();
            Peca PecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }
        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).toPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).toPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());

            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('a', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('b', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('f', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('g', 2).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('h', 2).toPosicao());

            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('a', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('b', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('f', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('g', 7).toPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('h', 7).toPosicao());
        }
    }
}
