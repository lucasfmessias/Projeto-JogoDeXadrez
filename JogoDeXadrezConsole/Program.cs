using System;
using tabuleiro;

namespace JogoDeXadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
