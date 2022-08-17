using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());            

            string temp = stack.Pop();

            int sum = 0;

            while (stack.Count > 0)
            {

                if (temp == "-")
                {
                    sum -= int.Parse(stack.Pop());
                    if (stack.Count > 0)
                    {
                        temp = stack.Pop();
                        continue;
                    }
                    continue;
                }
                else if (temp == "+")
                {                    
                    sum += int.Parse(stack.Pop());
                    if (stack.Count > 0)
                    {
                        temp = stack.Pop();
                        continue;
                    }                   
                    continue;
                }
                sum = int.Parse(temp);
                temp = stack.Pop();
            }
            Console.WriteLine(sum);
        }
    }
}
