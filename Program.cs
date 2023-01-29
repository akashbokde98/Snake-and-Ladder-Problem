using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rndNum = new Random();
            Console.WriteLine("Snake and Ladder Game Played With Single Player at Start Position 0.");
            int player1_Position = 0;
            int player2_Position = 0;
            int winPosition = 100;

            while (player1_Position < winPosition && player2_Position < winPosition)
            {
                int dieNum1 = rndNum.Next(1, 7);
                int player1_Opt = rndNum.Next(0, 3);
                int dieNum2 = rndNum.Next(1, 7);
                int player2_Opt = rndNum.Next(0, 3);

                if (dieNum1 > dieNum2)
                {
                    if (player1_Opt == 1)
                    {
                        if ((player1_Position < 100) && (player1_Position + dieNum1 <= 100))
                        {
                            player1_Position += dieNum1;
                            Console.WriteLine("player1 Position:" + player1_Position);
                        }
                        continue;
                    }
                    else
                    {
                        if (player1_Opt == 2)
                        {
                            player1_Position += dieNum1 - dieNum1;
                            Console.WriteLine("player1 Position:" + player1_Position);
                        }
                        else
                        {
                            Console.WriteLine("No Play");
                        }

                    }
                }
                else
                {
                    if (player2_Opt == 1)
                    {
                        if ((player2_Position < 100) && (player2_Position + dieNum2 <= 100))
                        {
                            player2_Position += dieNum2;
                            Console.WriteLine("player2 Position:" + player2_Position);
                        }
                        continue;
                    }
                    else
                    {
                        if (player2_Opt == 2)
                        {
                            player2_Position += dieNum2 - dieNum2;
                            Console.WriteLine("player2 Position:" + player2_Position);
                        }
                        else
                        {
                            Console.WriteLine("No Play");
                        }

                    }
                }
            }
            if (player1_Position > player2_Position)
            {
                Console.WriteLine("Player_1 is Winner!");
            }
            else
            {
                Console.WriteLine("Player_2 is Winner!");
            }
        }
    }
}
