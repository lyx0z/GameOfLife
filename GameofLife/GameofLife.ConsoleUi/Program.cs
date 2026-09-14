namespace GameOfLife.ConsoleUi;

public static class Program
{
    public static void Main()
    {
        var conf = BoardSizeSetUp.GetBoardInfo();
        new Game(conf).Start();
    }
}
