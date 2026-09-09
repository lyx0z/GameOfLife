using static System.Console;

namespace GameofLife;

public class Game
{
    private Board board;

    public Game(GameConfig config)
    {
        board = new Board(config.Width, config.Height);
        board.RandomGen(config.AliveCount);
    }

    public void Start()
    {
        while (true)
        {
            Clear();
            CursorVisible = false;
            board.Print();
            Thread.Sleep(millisecondsTimeout: 500);
            board.UpdateBoard();
        }
    }
}
