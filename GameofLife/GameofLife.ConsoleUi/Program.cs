namespace GameofLife.ConsoleUi;

public class Program
{
    public static void Main()
    {
        var conf = BoardSizeSetUp.GetBoardSize();
        new Game(conf).Start();
    }
}
