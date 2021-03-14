using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "P";
        }
        public override bool[,] MovimentosPossiveis()
        {
            throw new NotImplementedException();
        }
    }
}
