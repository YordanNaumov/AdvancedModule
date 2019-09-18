using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] command = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (command[0])
                {
                    case 1:
                        stack.Push(command[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        var stackToFindMax = new Stack<int>(stack.Reverse());
                        GetBiggest(stackToFindMax);
                        break;
                    case 4:
                        var stackToFindMin = new Stack<int>(stack.Reverse());
                        GetSmallest(stackToFindMin);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));          
        }

        static void GetSmallest(Stack<int> stack)
        {
            if (stack.Count > 0)
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

        static void GetBiggest(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int biggestNumber = int.MinValue;
                while (stack.Count > 0)
                {
                    int currentNumber = stack.Peek();
                    if (biggestNumber < currentNumber)
                    {
                        biggestNumber = currentNumber;
                    }
                    stack.Pop();
                }
                Console.WriteLine(biggestNumber);
            }
        }
    }
}
