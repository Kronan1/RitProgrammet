using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitProgrammetSimon
{
    internal class Board
    {
        public static char[,] Initialize(int sizeY, int sizeX)
        {
            char[,] board = new char[sizeY, sizeX];
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = '!';
                }
            }
            return board;
        }
        public static void Draw(char[,] board)
        {
            for (int row = 0;  row < board.GetLength(0); row++)
            {
                for(int col = 0; col < board.GetLength(1); col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
