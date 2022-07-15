using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.__Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> initial = new Queue<int>();
            int index = 0;
          
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                initial.Enqueue(input[0]);
                initial.Enqueue(input[1]);
            }

            while (true)
            {
                Queue<int> initialCurr = new Queue<int>(initial);

                long litre = initialCurr.Dequeue();
                long distance = initialCurr.Dequeue();

                if (litre < distance)
                {
                    initial.Enqueue(initial.Dequeue());
                    initial.Enqueue(initial.Dequeue());
                }
                else if (litre >= distance)
                {
                    long leftFuel = litre - distance;

                    while (initialCurr.Any())
                    {
                        var litresInternal = initialCurr.Dequeue();
                        var distanceInternal = initialCurr.Dequeue();

                        if (litresInternal + leftFuel >= distanceInternal)
                        {
                            leftFuel = litresInternal + leftFuel - distanceInternal;
                        }
                        else
                        {
                            initial.Enqueue(initial.Dequeue());
                            initial.Enqueue(initial.Dequeue());
                            leftFuel = -1;
                            break;
                        }
                    }

                    if (leftFuel >= 0)
                    {
                        Console.WriteLine(index);
                        break;
                    }
                }
                index++;
            }
        }
    }
}