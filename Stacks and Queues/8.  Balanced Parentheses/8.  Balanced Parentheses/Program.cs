using System;
using System.Collections.Generic;

namespace _8.Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args) 
        {
            string input = Console.ReadLine();
            if (input.Length % 2 == 0)
            {
                var queue = new Queue<char>();
                var alternativeStartQueue = new Queue<char>();
                var alternativeEndQueue = new Queue<char>();
                var stack = new Stack<char>();              
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                    {
                        queue.Enqueue(input[i]);
                        alternativeStartQueue.Enqueue(input[i]);
                    }
                    else if (input[i] == '}' || input[i] == ']' || input[i] == ')')
                    {
                        stack.Push(input[i]);
                        alternativeEndQueue.Enqueue(input[i]);
                    }
                }

                if (queue.Count == input.Length / 2 && stack.Count == input.Length / 2)
                {
                    bool allValid = false;
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        int possibleDifference = 2;
                        if (queue.Peek() == 40)
                        {
                            possibleDifference = 1;
                        }

                        if (queue.Peek() + possibleDifference == stack.Peek())
                        {
                            queue.Dequeue();
                            stack.Pop();
                        }
                        else
                        {
                                break;
                        }

                        if (queue.Count == 0)
                        {
                            Console.WriteLine("YES");
                            allValid = true;
                            break;
                        }
                    }

                    for (int i = 0; i < input.Length && allValid == false; i++)
                    {
                        int possibleDifference = 2;
                        if (alternativeStartQueue.Peek() == 40)
                        {
                            possibleDifference = 1;
                        }

                        if (alternativeStartQueue.Peek() + possibleDifference == alternativeEndQueue.Peek())
                        {
                            alternativeStartQueue.Dequeue();
                            alternativeEndQueue.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            break;
                        }

                        if (alternativeStartQueue.Count == 0)
                        {
                            Console.WriteLine("YES"); 
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}