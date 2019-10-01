using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[size, size];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToArray();

                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = colElements[col];
                }
            }

            int knightsRemoved = 0;
            bool noAttacks = false;
            while (!noAttacks)
            {
                    int maxAttacks = 0;
                    int killerRow = 0;
                    int killerCol = 0;

                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        int knightsAttacked = 0;
                        if (chessBoard[row, col] == 'K')
                        {
                            //-2 1
                            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //-2 -1
                            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //1 -2
                            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //-1 -2
                            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //1 2
                            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //-1 2
                            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //2 -1
                            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                            {
                                knightsAttacked++;
                            }

                            //2 1
                            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                knightsAttacked++;
                            }
                        }

                        if (maxAttacks < knightsAttacked)
                        {
                            maxAttacks = knightsAttacked;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if(maxAttacks == 0)
                {
                    Console.WriteLine(knightsRemoved);
                    noAttacks = true;
                }
                else if (maxAttacks > 0)
                {
                    chessBoard[killerRow, killerCol] = '0';
                    knightsRemoved++;
                    maxAttacks = 0;
                }
            }
        }

        private static bool IsInside(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }
    }
}
