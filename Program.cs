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

            Random rndNum2 = new Random();
            int checkOpt = rndNum2.Next(0, 3);

            switch (checkOpt)
            {
                case 1:
                    playerPosition += dieNum;
                    break;

                case 2:
                    playerPosition += dieNum - dieNum;
                    break;

                default:
                    Console.WriteLine("No Play");
                    break;
            }
        }
    }
}
