namespace GameOfLife.ConsoleUi;

public class Program
{
    public static void Main()
    {
        var conf = BoardSizeSetUp.GetBoardInfo();
        new Game(conf).Start();
    }
}
