using GameOfLife.Core;

namespace GameOfLife.ConsoleUi;

public class BoardPrint
{
    public void Print(Board board)
    {
        for (var row = 0; row < board.Height; row++)
        {
            for (var col = 0; col < board.Width; col++)
            {
                Console.Write(board[row, col] ? "■ " : "  ");
            }
            Console.WriteLine();
        }
    }
}