using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsxNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int nNuberToPush = nsxNumbers[0];
            int sNuberToPopp = nsxNumbers[1];
            int xNuberToLook = nsxNumbers[2];
            Stack<int> nNumInStack = new Stack<int>();
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < nNuberToPush; i++)
            {
                nNumInStack.Push(numbers[i]);
            }
            if (sNuberToPopp < nNumInStack.Count)
            {
                for (int i = 0; i < sNuberToPopp; i++)
                {
                    nNumInStack.Pop();
                }
            }
            else
            {
                Console.WriteLine($"0");
                return;
            }
            
            if (nNumInStack.Contains(xNuberToLook))
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine($"{nNumInStack.Min()}");
            }



        }
    }
}
