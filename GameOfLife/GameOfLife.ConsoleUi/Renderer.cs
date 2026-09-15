namespace GameOfLife.ConsoleUi;

public static class Renderer
{
    public static void PrintBoard(bool[,] board)
    {
        for (var height = 0; height < board.GetLength(0); height++)
        {
            for (var width = 0; width < board.GetLength(1); width++)
            {
                Console.Write(board[height, width] ? "■ " : "  ");
            }
            Console.WriteLine();
        }
    }
}
