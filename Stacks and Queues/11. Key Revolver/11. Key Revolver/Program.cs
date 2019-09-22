using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int clipSize = int.Parse(Console.ReadLine());
            int[] inputBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(inputBullets);
            var locks = new Queue<int>(inputLocks);
            bool safeOpened = false;
            for (int i = 1; i <= inputBullets.Length; i++)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }
                if (i % clipSize == 0 && i < inputBullets.Length)
                {
                    Console.WriteLine("Reloading!");
                }
                if (locks.Count == 0) 
                {
                    int totalProfit = valueOfIntelligence - i * priceOfBullet;
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${totalProfit}");
                    safeOpened = true;
                    break;
                }
            }

            if (safeOpened == false)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
