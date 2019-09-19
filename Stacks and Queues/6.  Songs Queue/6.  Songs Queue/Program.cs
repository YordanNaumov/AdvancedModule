using System;
using System.Collections.Generic;

namespace _6.Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var queueOfSongs = new Queue<string>(songs);

            while (queueOfSongs.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queueOfSongs.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);
                    if (queueOfSongs.Contains(song))
                    {
                        Console.WriteLine(song + " is already contained!");
                    }
                    else
                    {
                        queueOfSongs.Enqueue(song);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queueOfSongs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
