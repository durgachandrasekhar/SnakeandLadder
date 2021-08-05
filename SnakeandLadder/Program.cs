using System;

namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake And Ladder problem");
            Random rand = new Random();
            int dicenumber = rand.Next(1,7);
            Console.WriteLine("The value of dice is " + dicenumber);
        }
    }
}
