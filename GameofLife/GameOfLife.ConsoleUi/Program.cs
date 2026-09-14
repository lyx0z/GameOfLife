using GameOfLife.Core;

namespace GameoOfLife.ConsoleUi;

public static class Program
{
    public static void Main()
    {
        var conf = BoardSizeSetUp.GetBoardInfo();
        new Game(conf).Start();
    }
}
