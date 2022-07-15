using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> gueue = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                gueue.Enqueue(input);
            }

            string someString = string.Empty;

            while (gueue.Count > 0)
            {
                string curCommand = gueue.Dequeue();
                string[] commandArray = curCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArray[0];

                if (command == "1")
                {
                    stack.Push(someString);
                    string text = commandArray[1];
                    someString = someString + text;

                }
                else if (command == "2")
                {
                    int index = int.Parse(commandArray[1]);
                    stack.Push(someString);
                    someString = someString.Remove(someString.Length - index, index);
                }
                else if (command == "3")
                {
                    int index = int.Parse(commandArray[1]);

                    for (int i = 1; i <= someString.Length; i++)
                    {
                        if (i == index)
                        {
                            Console.WriteLine(someString[i - 1]);
                            break;
                        }
                    }
                }
                else if (command == "4")
                {
                    someString = stack.Pop();
                }
            }
        }
    }
}