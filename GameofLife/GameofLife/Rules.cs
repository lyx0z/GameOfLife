namespace GameofLife;

public static class Rules
{
    public static bool[,] ComputeNextMove(bool[,] board)
    {
        var nextGen = new bool[board.GetLength(0), board.GetLength(1)];
        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                var isAlive = board[row, col];
                var neighbours = NeighbourCheck(board, row, col, isAlive);
                if (isAlive)
                {
                    switch (neighbours)
                    {
                        case 2:
                        case 3:
                        {
                            nextGen[row, col] = true;
                            break;
                        }
                        default:
                            nextGen[row, col] = false;
                            break;
                    }
                }
                if (neighbours == 3)
                {
                    nextGen[row, col] = true;
                }
            }
        }

        return nextGen;
    }

    private static int NeighbourCheck(bool[,] board, int row, int col, bool isAlive)
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
