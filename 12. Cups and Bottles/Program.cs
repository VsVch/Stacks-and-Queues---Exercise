using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cupsQueue = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> bottlesStack = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int wastedWater = 0;
            while (cupsQueue.Any() && bottlesStack.Count > 0)
            {
                int cup = cupsQueue.Dequeue();
                int bottle = bottlesStack.Pop();
                if (bottle > cup)
                {
                    wastedWater += bottle - cup;
                }
                else
                {
                    int cupQantityLeft = cup - bottle;
                    while (cupQantityLeft > 0)
                    {
                        int currentBottle = bottlesStack.Pop();
                        if (cupQantityLeft - currentBottle < 0)
                        {
                            wastedWater += currentBottle - cupQantityLeft;
                            break;
                        }
                        else
                        {
                            cupQantityLeft -= currentBottle;
                        }
                    }
                }
            }
            if (bottlesStack.Any()){Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");}
            if (cupsQueue.Any()){Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");}
            Console.WriteLine($"Wasted litters of water: {wastedWater}");

        }
    }
}