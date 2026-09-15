using GameOfLife.Core;

namespace GameoOfLife.ConsoleUi;

public class Program
{
    private readonly Board board;

    public Program(GameConfig config)
    {
        board = new Board(config.Width, config.Height);
        board.GenerateRandom(config.AliveCount);
    }

    public static void Main()
    {
        var conf = BoardSizeSetUp.GetBoardInfo();
        var program = new Program(conf);
       
        while (true)
        {
            Console.Clear();
            Console.CursorVisible = false;
            program.board.Print();
            Thread.Sleep(millisecondsTimeout: 100);
            program.board.UpdateBoard();
        }
    }
}
   


