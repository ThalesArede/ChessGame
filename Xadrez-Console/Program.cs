// classe program
using System;
using tabuleiro; // Adicionamos o using tabuleiro
using xadrez;


namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0)); // Colocamos uma torre na posição 0, 0
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3)); // Colocamos uma torre na posição 1, 3
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4)); // Colocamos uma rei na posição 2, 4

            Tela.imprimirTabuleiro(tab); // Comando que chamamos para imprimir o tabuleiro na tela (CMD)

            Console.ReadLine(); // ReadLine adicionado para que espere apertarmos o "Enter"
        }
    }
}