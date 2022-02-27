using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) // Construtor que recebe uma mensagem e repassa para classe exception
        {

        }
    }
}
