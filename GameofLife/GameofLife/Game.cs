namespace GameofLife;

public class Game
{
    private bool[,] board;

    public Game(GameConfig config)
    {
        board = new bool[config.Height, config.Width];
    }

    public void Start()
    {
        Board.RandomGen(board);
        while (true)
        {
            Board.Print(board);
            Thread.Sleep(1500);
            Console.Clear();
            //Board Update
        }
    }
}
