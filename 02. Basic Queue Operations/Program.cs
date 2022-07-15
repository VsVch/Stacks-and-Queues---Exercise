using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsxNumbes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int nNum = nsxNumbes[0];
            int sNum = nsxNumbes[1];
            int xNum = nsxNumbes[2];
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> numInQueue = new Queue<int>();
            for (int i = 0; i < nNum; i++)
            {
                numInQueue.Enqueue(numbers[i]);
            }
            for (int j = 0; j < sNum; j++)
            {
                numInQueue.Dequeue();
            }
            if (numInQueue.Contains(xNum))
            {
                Console.WriteLine($"true");
            }
            else if (numInQueue.Count==0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                Console.WriteLine(numInQueue.Min());
            }





        }
    }
}
