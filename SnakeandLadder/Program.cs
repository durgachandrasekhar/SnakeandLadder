using System;

namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Ladder = 1;
            const int Snake = 2;
            int position = 0;
            int dieRoleCount = 0;
            Console.WriteLine("Snake And Ladder problem");
            while (position < 100)
            {
                Random rand = new Random();
                int dicenumber = rand.Next(1, 7);
                Console.WriteLine("The value of dice is " + dicenumber);
                int options = rand.Next(0, 3);
                dieRoleCount++;

                switch (options)
                {
                    case Ladder:
                        Console.WriteLine("player moves to ladder");
                        position += dicenumber;
                        break;
                    case Snake:
                        Console.WriteLine("player moves to Snake");
                        position -= dicenumber;
                        if (position <= 0)
                            position = 0;
                        break;
                    default:
                        Console.WriteLine("if player no play stays in same position");
                        break;

                }
                Console.WriteLine("The Position of Player Wins " + position);
                if (position > 100)
                    position -= dicenumber;
            }
            Console.WriteLine("The Total number of Times Die Role " + dieRoleCount);

        }
    }
}