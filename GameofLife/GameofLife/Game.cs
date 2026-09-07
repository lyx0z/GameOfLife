namespace GameofLife;

public class Game
{
    private bool[,] board;
    private readonly GameConfig config;

    public Game(GameConfig config)
    {
        this.config = config;
        board = new bool[config.Height, config.Width];
    }

    public void Start()
    {
        Board.RandomGen(board, config.AliveCount);
        while (true)
        {
            Board.Print(board);
            Thread.Sleep(1000);
            Console.Clear();
            //Board Update
        }
    }
}
