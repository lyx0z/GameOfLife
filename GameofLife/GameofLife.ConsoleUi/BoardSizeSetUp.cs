namespace GameofLife.ConsoleUi;

using GameofLife;

public static class BoardSizeSetUp
{
    public static BoardSize GetBoardSize()
    {
        Console.WriteLine("Whats going to be your board size?");

        Console.WriteLine("Width: ");
        var widthIsNumber = int.TryParse(Console.ReadLine(), out var boardWidth);

        Console.WriteLine("Height: ");
        var heightIsNumber = int.TryParse(Console.ReadLine(), out var boardHeight);

        if (!widthIsNumber || !heightIsNumber)
        {
            throw new ArgumentOutOfRangeException($"Oops! Please enter whole numbers dimensions");
        }

        if (boardWidth is < 1 or > 40)
        {
            throw new ArgumentOutOfRangeException($"Oops! Width must be between 1 and 100");
        }

        if (boardHeight is < 1 or > 40)
        {
            throw new ArgumentOutOfRangeException($"Oops! Height must be between 1 and 100");
        }

        var boardSize = new BoardSize { BoardWidth = boardWidth, BoardHeight = boardHeight };

        return boardSize;
    }
}
