namespace GameOfLife.Core;

public class Game
{
    private readonly Board board;

    public Game(GameConfig config)
    {
        board = new Board(config.Width, config.Height);
        board.GenerateRandom(config.AliveCount);
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.CursorVisible = false;
            board.Print();
            Thread.Sleep(millisecondsTimeout: 100);
            board.UpdateBoard();
        }
    }
}
