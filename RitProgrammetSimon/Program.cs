using System.Numerics;

namespace RitProgrammetSimon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cursorX = 0;
            int cursorY = 0;
            char savedChar = '!';
            char toChange = '0';
            char[,] board = Board.Initialize(20, 40);
            

            while (true)
            {
                Instructions.Draw();
                Board.Draw(board);
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.W)
                {

                }

                if (true)
                {

                }
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        board[cursorY, cursorX] = savedChar;
                        cursorY--;
                        if (cursorY >= 0)
                        {
                            savedChar = board[cursorY, cursorX];
                            board[cursorY, cursorX] = 'X';
                        }
                        else { cursorY++; }
                        break;

                    case ConsoleKey.S:
                        board[cursorY, cursorX] = savedChar;
                        cursorY++;
                        if (cursorY < board.GetLength(0))
                        {
                            savedChar = board[cursorY, cursorX];
                            board[cursorY, cursorX] = 'X';
                        }
                        else { cursorY--; }
                        break;

                    case ConsoleKey.D:
                        board[cursorY, cursorX] = savedChar;
                        cursorX++;
                        if (cursorX < board.GetLength(1))
                        {
                            savedChar = board[cursorY, cursorX];
                            board[cursorY, cursorX] = 'X';
                        }
                        else { cursorX--; }
                        break;

                    case ConsoleKey.A:
                        board[cursorY, cursorX] = savedChar;
                        cursorX--;
                        if (cursorX >= 0)
                        {
                            savedChar = board[cursorY, cursorX];
                            board[cursorY, cursorX] = 'X';
                        }
                        else { cursorX++; }
                        break;

                    case ConsoleKey.Enter:
                        board[cursorY, cursorX] = toChange;
                        savedChar = toChange;
                        break;

                    default:
                        toChange = key.KeyChar;
                        break;
                }
                
                
                Console.Clear();
            }
        }
    }
}