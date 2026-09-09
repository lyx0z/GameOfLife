namespace GameofLife;

public class Board
{
    private bool[,] board;

    public Board(int width, int height)
    {
        board = new bool[height, width];
    }

    public void Print()
    {
        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                Console.Write(board[row, col] ? "■ " : "  ");
            }
            Console.WriteLine();
        }
    }

    public void GenerateRandom(int aliveCount)
    {
        var generator = new Random();
        var rows = board.GetLength(0);
        var cols = board.GetLength(1);
        var placed = 0;

        while (placed < aliveCount)
        {
            var row = generator.Next(rows);
            var col = generator.Next(cols);
            if (!board[row, col])
            {
                board[row, col] = true;
                placed++;
            }
        }
    }

    public void UpdateBoard()
    {
        board = Rules.ComputeNextMove(board);
    }
}
