using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            int count = int.Parse(Console.ReadLine());

            int countPassedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");

                            countPassedCars++;
                        }                        
                    }
                    continue;
                }
                queue.Enqueue(input);
            }
            Console.WriteLine($"{countPassedCars} cars passed the crossroads.");
        }
    }
}
