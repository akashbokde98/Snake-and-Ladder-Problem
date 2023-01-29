using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game Played With Single Player at Start Position 0.");
            int playerPosition = 0;
            Random rndNum = new Random();
            int dieNum = rndNum.Next(1, 7);
        }
    }
}
