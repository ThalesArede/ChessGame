using System;
using tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        // Método static vai imprimir o tabuleiro na tela, é void pois não retorna nenhum valor

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++) // i = linhas
            {
                for (int j = 0; j < tab.colunas; j++) // j = colunas
                {
                    if (tab.peca(i, j) == null) // Se a peça na posição i, j for nulo, imprime o traço "-" na tela
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
