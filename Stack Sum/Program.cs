using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                string[] commandArguments = command.Split();

                string currentCommand = commandArguments[0];


                if (currentCommand == "add")
                {
                    stack.Push(int.Parse(commandArguments[1]));
                    stack.Push(int.Parse(commandArguments[2]));
                }
                else
                {
                    if (stack.Count < int.Parse(commandArguments[1]))
                    {
                        continue;
                    }

                    for (int i = 0; i < int.Parse(commandArguments[1]); i++)
                    {
                        stack.Pop();
                    }
                }
            }

            Console.WriteLine("\r\n" + "The sum is: " + stack.Sum());
        }
    }
}
