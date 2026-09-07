namespace GameofLife.ConsoleUi;

public class Program
{
    public static void Main()
    {
        var boardSize = BoardSizeSetUp.GetBoardSize();
        var board = Board.CreatePlayingBoard(boardSize.BoardHeight, boardSize.BoardWidth);

        Console.Clear();
        while (true)
        {
            //updatecells()
            //etc
            BoardPrinter.Print(board);
            Thread.Sleep(700);
            Console.Clear();
        }
    }
}
