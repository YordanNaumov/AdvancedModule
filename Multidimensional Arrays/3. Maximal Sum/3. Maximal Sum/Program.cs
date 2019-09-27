using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console
                    .ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sizeOfSmallMatrix = 3;
            int globalMaximumSum = int.MinValue;
            int[] startingPosition = new int[2];
            for (int i = 0; i < matrix.GetLength(0) - sizeOfSmallMatrix + 1; i++)
            {
                for (int p = 0; p < matrix.GetLength(1) - sizeOfSmallMatrix + 1; p++)
                {
                    int currentSum = 0;
                    for (int row = i; row < sizeOfSmallMatrix + i; row++)
                    {
                        for (int col = p; col < sizeOfSmallMatrix + p; col++)
                        {
                            currentSum += matrix[row, col];
                        }
                    }
                    if (currentSum > globalMaximumSum)
                    {
                        globalMaximumSum = currentSum;
                        startingPosition[0] = i;
                        startingPosition[1] = p;
                    }
                }
            }
            Console.WriteLine("Sum = " + globalMaximumSum);

            for (int row = startingPosition[0]; row < startingPosition[0] + sizeOfSmallMatrix; row++)
            {
                for (int col = startingPosition[1]; col < startingPosition[1] + sizeOfSmallMatrix; col++)
                {
                    Console.Write(matrix[row, col]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
