namespace GameofLife;

public class Game
{
    private bool[,] board;
    private readonly GameConfig config;

    public Game(GameConfig config)
    {
        this.config = config;
        board = new bool[config.Height, config.Width];
        Board.RandomGen(board, config.AliveCount);
    }

    public void Start()
    {
        while (true)
        {
            Board.Print(board);
            Thread.Sleep(100);
            Console.Clear();
            board = Board.UpdateBoard(board);
        }
    }
}
