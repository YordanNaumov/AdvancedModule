using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int numberOfBottles = bottles.Count();
            int waterWasted = 0;
            bool noBottlesLeft = true;

            for (int i = 0; i < numberOfBottles; i++)
            {
                if (bottles.Peek() == cups.Peek())
                {
                    bottles.Pop();
                    cups.Dequeue();
                }
                else if (bottles.Peek() < cups.Peek())
                {
                    var emptyCups = new List<int>();
                    emptyCups.Add(cups.Dequeue() - bottles.Pop());
                    emptyCups.AddRange(cups);
                    cups = new Queue<int>(emptyCups);
                }
                else if (bottles.Peek() > cups.Peek())
                {
                    waterWasted += bottles.Pop() - cups.Dequeue(); 
                }

                if (cups.Count == 0)
                {
                    Console.Write($"Bottles: ");
                    foreach (var bottle in bottles)
                    {
                        Console.Write($"{bottle} ");
                    }
                    noBottlesLeft = false;
                    break;
                }
            }

            if (noBottlesLeft)
            {
                Console.Write($"Cups: ");
                foreach (var cup in cups)
                {
                    Console.Write($"{cup} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Wasted litters of water: {waterWasted}");
        }
    }
}
