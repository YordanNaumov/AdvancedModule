using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var queueOfOreders = new Queue<int>(orders);

            if (orders.Length > 0)
            {
                int biggestOrder = int.MinValue;
                for (int i = 0; i < orders.Length; i++)
                {
                    int currentOrder = orders[i];
                    if (biggestOrder < currentOrder)
                    {
                        biggestOrder = currentOrder;
                    }
                }
                Console.WriteLine(biggestOrder);
            }

            while (queueOfOreders.Count > 0)
            {
                if (queueOfOreders.Peek() <= quantityOfFood)
                {
                    quantityOfFood -= queueOfOreders.Peek();
                    queueOfOreders.Dequeue();
                }
                else
                {
                    Console.Write("Orders left: ");
                    Console.Write(string.Join(" ", queueOfOreders));
                    break;
                }
            }

            if (queueOfOreders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
