namespace GameOfLife;

public static class Rules
{
    public static bool[,] ComputeNextMove(bool[,] board)
    {
        var nextGen = new bool[board.GetLength(0), board.GetLength(1)];

        for (var row = 0; row < board.GetLength(0); row++)
        for (var col = 0; col < board.GetLength(1); col++)
            nextGen[row, col] = AliveNextGen(
                board[row, col],
                GetAliveNeighborCount(board, row, col)
            );

        return nextGen;
    }

    public static bool AliveNextGen(bool isAlive, int neighbours)
    {
        if (isAlive)
        {
            return neighbours is 2 or 3;
        }
        return neighbours == 3;
    }

    public static int GetAliveNeighborCount(bool[,] board, int row, int col)
    {
        var sum = 0;

        for (var rowOffset = -1; rowOffset <= 1; rowOffset++)
        {
            for (var colOffset = -1; colOffset <= 1; colOffset++)
            {
                if (rowOffset == 0 && colOffset == 0)
                {
                    continue;
                }

                var neighbourRow = row + rowOffset;
                var neighbourCol = col + colOffset;

                if (neighbourRow < 0 || neighbourRow >= board.GetLength(0))
                {
                    continue;
                }

                if (neighbourCol < 0 || neighbourCol >= board.GetLength(1))
                {
                    continue;
                }

                if (board[neighbourRow, neighbourCol])
                {
                    sum++;
                }
            }
        }

        return sum;
    }
}
