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

            char[,] matrix = new char[sizes[0], sizes[1]];
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console
                    .ReadLine()
                    .Split()
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int numberOfEqualSquares = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char expectedChar = matrix[row, col];

                    if (matrix[row + 1, col] == expectedChar && matrix[row, col + 1] == expectedChar && matrix[row + 1, col + 1] == expectedChar)
                    {
                        numberOfEqualSquares++;
                    }
                }
            }

            Console.WriteLine(numberOfEqualSquares);
        }
    }
}
