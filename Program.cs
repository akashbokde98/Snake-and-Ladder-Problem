using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game Played With Single Player at Start Position 0.");
            int playerPosition = 0;
            int winPosition = 100;

            Random rndNum = new Random();
            int dieNum = rndNum.Next(1, 7);

            Random rndNum2 = new Random();
            //int checkOpt = rndNum2.Next(0, 3);

            while (playerPosition < winPosition)
            {
                switch (rndNum2.Next(0, 3))
                {
                    case 1:
                        playerPosition += dieNum;
                        Console.WriteLine("playerPosition:" + playerPosition);
                        break;

                    case 2:
                        playerPosition += dieNum - dieNum;
                        Console.WriteLine("playerPosition:" + playerPosition);
                        break;

                    default:
                        Console.WriteLine("No Play");
                        break;
                }
            }
        }
    }
}
