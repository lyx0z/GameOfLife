namespace GameofLife;

public static class Board
{
    public static bool[,] CreatePlayingBoard(int boardHeight, int boardWidth)
    {
        var board = new bool[boardHeight, boardWidth];
        return board;
    }
}
