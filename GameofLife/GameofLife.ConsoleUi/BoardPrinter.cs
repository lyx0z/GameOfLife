namespace GameofLife.ConsoleUi;

public static class BoardPrinter
{
    public static void Print(bool[,] board)
    {
        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col] ? "■ " : " x ");
            }
            Console.WriteLine();
        }
    }
}
