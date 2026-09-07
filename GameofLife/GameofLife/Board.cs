namespace GameofLife;

public class Board
{
    public static void Print(bool[,] board)
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

    public static void RandomGen(bool[,] board)
    {
        var generator = new Random();

        for (var row = 0; row < board.GetLength(0); row++)
        {
            for (var col = 0; col < board.GetLength(1); col++)
            {
                var number = generator.NextDouble();
                var rounded = (int)Math.Round(number);
                board[row, col] = rounded == 1;
            }
        }
    }
}
