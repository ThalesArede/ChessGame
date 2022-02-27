using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca // Classe Torre Herdando da classe Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}