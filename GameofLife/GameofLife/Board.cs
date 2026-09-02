namespace GameofLife;

public static class Board
{
    public static void PlayingBoard(int boardHeight, int boardWidth)
    {
        var board = new bool[boardHeight, boardWidth];
        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col] ? "■ " : "  ");
            }
            Console.WriteLine();
        }
    }
}
