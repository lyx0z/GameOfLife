using System.Data;

namespace GameofLife;

public class Rules
{
    public static bool[,] ComputeNextMove(bool[,] board)
    {
        var nextGen = new bool[board.GetLength(0), board.GetLength(1)];
        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                var neighbours = NeighbourCheck(board, row, col);
                var isAlive = board[row, col];
                if (isAlive)
                {
                    switch (neighbours)
                    {
                        case 2:
                            nextGen[row, col] = true;
                            break;
                        case 3:
                            nextGen[row, col] = true;
                            break;
                        default:
                            nextGen[row, col] = false;
                            break;
                    }
                }
                else
                {
                    if (neighbours == 3)
                    {
                        nextGen[row, col] = true;
                    }
                    else
                    {
                        nextGen[row, col] = false;
                    }
                }
            }
        }

        return nextGen;
    }

    private static int NeighbourCheck(bool[,] board, int num1, int num2)
    {
        var sum = 0;

        for (var i = -1; i <= 1; i++)
        {
            for (var k = -1; k <= 1; k++)
            {
                try
                {
                    if (board[num1 + i, num2 + k])
                        sum++;
                }
                catch
                {
                    // ignored
                }
            }
        }
        sum--;
        return sum;
    }
}
