// classe program
using System;
using tabuleiro; // Adicionamos o using tabuleiro
namespace Xadrez_Console
{
    class Program
    {
    static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab); // Comando que chamamos para imprimir o tabuleiro na tela (CMD)

        Console.ReadLine(); // ReadLine adicionado para que espere apertarmos o "Enter"
        }
    }
}