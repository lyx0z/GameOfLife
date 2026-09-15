namespace GameOfLife.Core;

public class Board
{
    private bool[,] board;

    public Board(int width, int height)
    {
        board = new bool[height, width];
    }

    public int Height => board.GetLength(0);

    public int Width => board.GetLength(1);

    public bool this[int row, int col] => board[row, col];

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
