using GameofLife;

namespace GameofLife.ConsoleUi;

public class Program
{
    public static void Main()
    {
        const bool running = true;
        var boardSize = BoardSizeSetUp.BoardSizeAsk();
        while (running)
        {
            Console.Clear();
            Board.PlayingBoard(boardSize.BoardWidth, boardSize.BoardHeight);
        }
    }
}
