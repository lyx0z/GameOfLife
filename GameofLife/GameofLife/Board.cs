namespace GameofLife;

public class Board
{
    private bool[,] boardField;

    public Board(int height, int width)
    {
        boardField = new bool[height, width];
    }

    public bool[,] GetBoard()
    {
        return boardField;
    }

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
