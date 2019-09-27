using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Snake_Moves
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

            char[,] matrix = new char[sizes[0], sizes[1]];

            string snake = Console.ReadLine();
            string currentSnake = snake;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = currentSnake[0];
                        currentSnake = currentSnake.Remove(0, 1);

                        if (currentSnake.Length == 0)
                        {
                            currentSnake = snake;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = currentSnake[0];
                        currentSnake = currentSnake.Remove(0, 1);

                        if (currentSnake.Length == 0)
                        {
                            currentSnake = snake;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
