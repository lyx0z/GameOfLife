using GameOfLife.Core;

namespace GameOfLife.ConsoleUi;

public class Program
{
    public readonly Board board;
    
    public Program(GameConfig config)
    {
        board = new Board(config.Width, config.Height);
        board.GenerateRandom(config.AliveCount);
    }

    public static void Main()
    {
        var conf = BoardSizeSetUp.GetBoardInfo();
        var program = new Program(conf);
        var boardPrint = new BoardPrint();
        while (true)
        {
            Console.Clear();
            Console.CursorVisible = false; 
            boardPrint.Print(program.board); 
            Thread.Sleep(millisecondsTimeout: 100); 
            program.board.UpdateBoard(); 
        }
    }
}
   


