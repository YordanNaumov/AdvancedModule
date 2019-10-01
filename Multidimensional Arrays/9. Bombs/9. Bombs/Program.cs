using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            string[] bombs = Console.ReadLine()
                .Split()
                .ToArray();

            var bombIndexes = new Dictionary<int, List<int>>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                bombIndexes[row] = new List<int>();
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] indexes = bombs[i]
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                bombIndexes[indexes[0]].Add(indexes[1]);
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] indexes = bombs[i]
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int row = indexes[0];
                int col = indexes[1];

                int damageFactor = matrix[row, col];
                matrix[row, col] = 0;

                //-1 -1
                if (IsInside(matrix, row - 1, col - 1) && !(bombIndexes.ContainsKey(row - 1) && bombIndexes[row - 1].Contains(col - 1)))
                {
                    matrix[row - 1, col - 1] -= damageFactor;
                    bombIndexes[row - 1].Add(col - 1);
                }

                //0 -1 
                if (IsInside(matrix, row, col - 1) && !(bombIndexes.ContainsKey(row) && bombIndexes[row].Contains(col - 1)))
                {
                    matrix[row, col - 1] -= damageFactor;
                    bombIndexes[row].Add(col - 1);
                }

                //1 -1
                if (IsInside(matrix, row + 1, col - 1) && !(bombIndexes.ContainsKey(row + 1) && bombIndexes[row + 1].Contains(col - 1)))
                {
                    matrix[row + 1, col - 1] -= damageFactor;
                    bombIndexes[row + 1].Add(col - 1);
                }

                //-1 0
                if (IsInside(matrix, row - 1, col) && !(bombIndexes.ContainsKey(row - 1) && bombIndexes[row - 1].Contains(col)))
                {
                    matrix[row - 1, col] -= damageFactor;
                    bombIndexes[row - 1].Add(col);
                }

                //1 0
                if (IsInside(matrix, row + 1, col) && !(bombIndexes.ContainsKey(row + 1) && bombIndexes[row + 1].Contains(col)))
                {
                    matrix[row + 1, col] -= damageFactor;
                    bombIndexes[row + 1].Add(col);
                }

                //-1 1
                if (IsInside(matrix, row - 1, col + 1) && !(bombIndexes.ContainsKey(row - 1) && bombIndexes[row - 1].Contains(col + 1)))
                {
                    matrix[row - 1, col + 1] -= damageFactor;
                    bombIndexes[row - 1].Add(col + 1);
                }

                // 0 1
                if (IsInside(matrix, row, col + 1) && !(bombIndexes.ContainsKey(row) && bombIndexes[row].Contains(col + 1)))
                {
                    matrix[row, col + 1] -= damageFactor;
                    bombIndexes[row].Add(col + 1);
                }

                // 1 1
                if (IsInside(matrix, row + 1, col + 1) && !(bombIndexes.ContainsKey(row + 1) && bombIndexes[row + 1].Contains(col + 1)))
                {
                    matrix[row + 1, col + 1] -= damageFactor;
                    bombIndexes[row + 1].Add(col + 1);
                }
            }

            int aliveCells = 0;
            int aliveCellsSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        aliveCellsSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        private static bool IsInside(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
