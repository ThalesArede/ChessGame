using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca // Classe Rei Herdando da classe Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}