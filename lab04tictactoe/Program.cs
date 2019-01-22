using Lab04_TicTacToe.Classes;
using System;

namespace lab04tictactoe
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool rungame = true;
            while (rungame == true)
            {
                Console.WriteLine("Game is about to start");
                Console.WriteLine("welcome,what was your name?: ");
                string nameplayer1 = Console.ReadLine();
                Console.WriteLine($"Hi {nameplayer1} your marker is \"X");
                Player p1 = new Player();
                p1.Name = nameplayer1;

                Console.WriteLine("welcome,what was your name?: ");
                string nameplayer2 = Console.ReadLine();
                Console.WriteLine($"Hi {nameplayer2} your marker is \"O");
                Player p2 = new Player();
                p1.Name = nameplayer2;


                Game game = new Game(p1, p2);
                Player winner = game.Play();
                if( winner != null){
                    Console.WriteLine($"Winner is {winner.Name}");
                }
                Console.WriteLine("you wanna start a new game? yes/no");
                string input = Console.ReadLine();
                string input2 = input.ToLower();
                if (input == "yes") rungame = true;
                else rungame = false;


            }

            Environment.Exit(0);
        }
    }
}
