using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] com = Console.ReadLine().Split();
                if (com[0] == "1")
                {
                    numbers.Push(int.Parse(com[1]));
                }
                if (numbers.Any())
                {
                    if (com[0] == "2")
                    {

                        numbers.Pop();


                    }
                    if (com[0] == "3")
                    {
                        Console.WriteLine(numbers.Max());
                    }
                    if (com[0] == "4")
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
                

            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
