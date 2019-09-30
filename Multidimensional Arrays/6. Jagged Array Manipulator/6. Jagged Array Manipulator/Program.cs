using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {
                int[] inputNumbers = Console
                    .ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = new double[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = inputNumbers[col];
                }
            }

            for (int row = 0; row < numberOfRows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] command = Console
                    .ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < numberOfRows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < numberOfRows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    foreach (double[] row in jagged)
                    {
                        Console.WriteLine(string.Join(" ", row));
                    }
                    break;
                }
            }
        }
    }
}