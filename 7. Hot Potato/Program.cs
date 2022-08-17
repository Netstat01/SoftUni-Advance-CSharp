using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Queue<string> game = new Queue<string>(input);

            int coount = int.Parse(Console.ReadLine());

            while (game.Count > 1)
            {
                for (int i = 1; i < coount; i++)
                {
                    string firstDequeue = game.Dequeue();

                    game.Enqueue(firstDequeue);
                }
                Console.WriteLine($"Removed {game.Dequeue()}");
            }
            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
