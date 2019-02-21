using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPokerGame pokerGame = new PokerGame();

            pokerGame.Jogar();
            Console.WriteLine("Hello World!");
        }
    }
}
