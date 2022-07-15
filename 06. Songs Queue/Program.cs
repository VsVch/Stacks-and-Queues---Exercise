using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songsToPlay = new Queue<string>(songs);
            string command = Console.ReadLine();
            while (songsToPlay.Count > 0)
            {
                
                if (command.Contains("Play"))
                {
                    songsToPlay.Dequeue();
                }
                if (command.Contains("Add"))
                {
                    string song = command.Substring(3, command.Length - 3).Trim();
                    if (songsToPlay.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsToPlay.Enqueue(song);
                    }
                }
                if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songsToPlay));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"No more songs!");
        }
    }
}
