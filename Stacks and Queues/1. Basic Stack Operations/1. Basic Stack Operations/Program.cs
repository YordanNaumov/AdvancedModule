using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Basic_Stack_Operations
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

            int elementsToPush = elements[0];
            int elementsToPop = elements[1];
            int elementToSearch = elements[2];

            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < elementsToPush && i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                GetSmallest(stack);
            }
        }

        static void GetSmallest(Stack<int> stack)
        {
            int smallestNumber = int.MaxValue;

            while (stack.Count > 0)
            {
                int currentNumber = stack.Peek();
                if (smallestNumber > currentNumber)
                {
                    smallestNumber = currentNumber;
                }
                stack.Pop();
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
