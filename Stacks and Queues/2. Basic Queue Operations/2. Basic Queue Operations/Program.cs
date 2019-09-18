using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console
               .ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int elementsToEnqueue = elements[0];
            int elementsToDequeue = elements[1];
            int elementToSearch = elements[2];

            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue && i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToDequeue && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                GetSmallest(queue);
            }
        }

        static void GetSmallest(Queue<int> queue)
        {
            int smallestNumber = int.MaxValue;

            while (queue.Count > 0)
            {
                int currentNumber = queue.Peek();
                if (smallestNumber > currentNumber)
                {
                    smallestNumber = currentNumber;
                }
                queue.Dequeue();
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
