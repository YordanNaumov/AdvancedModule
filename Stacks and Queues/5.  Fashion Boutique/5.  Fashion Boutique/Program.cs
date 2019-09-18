using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());
            int currentCapacity = capacityOfRack;
            var pileOfClothes = new Stack<int>(clothes);
            int numberOfRacks = 1;
            while (pileOfClothes.Count > 0)
            {
                int valueOfClothes = pileOfClothes.Peek();
                if (currentCapacity >= valueOfClothes)
                {
                    currentCapacity -= pileOfClothes.Peek();
                    pileOfClothes.Pop();
                }
                else
                {
                    numberOfRacks++;
                    currentCapacity = capacityOfRack - pileOfClothes.Peek();
                    pileOfClothes.Pop();
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
