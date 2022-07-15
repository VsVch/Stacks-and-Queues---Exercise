using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfTheFood = int.Parse(Console.ReadLine());
            int[] quantityOfOrder = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(quantityOfOrder);
            int sum = 0;
            Console.WriteLine(orders.Max());
            for (int i = 0; i < quantityOfOrder.Length; i++)
            {
                if (quantityOfTheFood >= orders.Peek())
                {
                    quantityOfTheFood -= orders.Peek();
                    orders.Dequeue();
                    
                }
                else
                {
                    Console.Write($"Orders left: ");
                    Console.Write(string.Join(" ", orders));
                    return;
                }

            }
            Console.Write($"Orders complete ");
            
           
        }
    }
}
