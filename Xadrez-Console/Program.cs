using System;
using tabuleiro; // Adicionamos o using tabuleiro
namespace Xadrez_Console
{
    class Program
    {
    static void Main(string[] args)
        {

        Posicao P; // Variável do tipo posicao

        P = new Posicao(3, 4); // novo objeto posicao


        Console.WriteLine("Posição: " + P);

        Console.ReadLine(); // ReadLine adicionado para que espere apertarmos o "Enter"
        }
    }
}