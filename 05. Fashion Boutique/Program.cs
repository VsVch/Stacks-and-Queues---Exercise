using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            int count = 0;
            Stack<int> clothes = new Stack<int>(clothesInBox);
            int sum = 0;
            for (int i = 0; i < clothesInBox.Length; i++)
            {
                sum += clothes.Peek();
                if (sum > capacityOfRack)
                {
                    count++;
                    sum = clothes.Peek();
                }
                clothes.Pop();
            }

            if (sum > 0)
            {
                count++;
            }
            Console.WriteLine(count);






        }
    }
}
