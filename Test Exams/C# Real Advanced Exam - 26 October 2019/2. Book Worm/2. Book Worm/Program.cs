using System;
using System.Linq;

namespace _2._Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();

            int size = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];

            //player position
            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = colElements[col];
                    if (field[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                        field[row, col] = '-';
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "up" && IsInside(field, currentRow - 1, currentCol))
                {
                    currentRow--;

                    if (field[currentRow, currentCol] != '-')
                    {
                        @string += field[currentRow, currentCol];
                        field[currentRow, currentCol] = '-';
                    }
                }
                else if (command == "down" && IsInside(field, currentRow + 1, currentCol))
                {
                    currentRow++;

                    if (field[currentRow, currentCol] != '-')
                    {
                        @string += field[currentRow, currentCol];
                        field[currentRow, currentCol] = '-';
                    }
                }
                else if (command == "left" && IsInside(field, currentRow, currentCol - 1))
                {
                    currentCol--;

                    if (field[currentRow, currentCol] != '-')
                    {
                        @string += field[currentRow, currentCol];
                        field[currentRow, currentCol] = '-';
                    }
                }
                else if (command == "right" && IsInside(field, currentRow, currentCol + 1))
                {
                    currentCol++;

                    if (field[currentRow, currentCol] != '-')
                    {
                        @string += field[currentRow, currentCol];
                        field[currentRow, currentCol] = '-';
                    }
                }
                else
                {
                    if (@string.Length > 0)
                    {
                        @string = @string.Remove(@string.Length - 1);
                    }
                }
                command = Console.ReadLine();
            }

            field[currentRow, currentCol] = 'P';

            Console.WriteLine(@string);
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        static bool IsInside(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
        }
    }
}
