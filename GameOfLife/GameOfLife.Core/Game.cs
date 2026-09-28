namespace GameOfLife.Core;

public class Game(int width, int height, int aliveCount)
{
    private readonly Board board = new(width, height, aliveCount);

    public void SwapState(int width, int height)
    {
        board.SwapState(width, height);
    }

    public bool[,] GetNextFrame()
    {
        board.GenerateNextFrame();
        return board.GetBoard();
    }
}
