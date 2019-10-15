using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int> addOne = x => x += 1;
            Func<int, int> subtractsOne = x => x -= 1;
            Func<int, int> multiply = x => x *= 2;
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "add")       
                {
                    numbers = numbers.Select(addOne).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtractsOne).ToArray();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
