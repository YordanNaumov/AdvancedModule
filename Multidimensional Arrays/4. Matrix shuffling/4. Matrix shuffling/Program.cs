using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matrix_shuffling
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

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console
                    .ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            while (true)
            {
                string[] command = Console
                    .ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "swap" && command.Length == 5)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    SwapPlaces(matrix, row1, col1, row2, col2);
                }
                else if (command[0] == "END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public static string[,] SwapPlaces(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            if (row1 < matrix.GetLength(0) && row2 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && col2 < matrix.GetLength(1))
            {
                string temporaryString = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temporaryString;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]+ ' ');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            return matrix;
        }
    }
}
