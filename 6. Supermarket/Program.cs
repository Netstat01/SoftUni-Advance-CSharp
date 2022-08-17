using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    foreach (var item in names)
                    {
                        Console.WriteLine(item);
                    }
                    names.Clear();
                    input = Console.ReadLine();
                }
                else
                {                    
                    names.Enqueue(input);
                    input = Console.ReadLine();
                }                
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
