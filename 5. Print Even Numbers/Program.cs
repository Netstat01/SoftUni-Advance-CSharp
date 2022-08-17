using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> input = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int temp = 0;

            if (input.Any(x => x % 2 == 1))
            {
                while (true)
                {
                    if (input.Count == 0)
                    {
                        break;
                    }
                    if (input.Peek() % 2 == 0)
                    {
                        temp = input.Dequeue();
                        input.Enqueue(temp);

                        if (!input.Any(x => x % 2 == 1))
                        {
                            break;
                        }
                    }
                    else if (input.Peek() % 2 == 1)
                    {
                        input.Dequeue();
                    }
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
