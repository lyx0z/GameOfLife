namespace GameofLife.ConsoleUi;

public static class BoardSizeSetUp
{
    public static GameConfig GetBoardInfo()
    {
        Console.WriteLine("Whats going to be your board size?");

        Console.WriteLine("Width: ");
        var widthIsNumber = int.TryParse(Console.ReadLine(), out var boardWidth);

        Console.WriteLine("Height: ");
        var heightIsNumber = int.TryParse(Console.ReadLine(), out var boardHeight);

        if (!widthIsNumber || !heightIsNumber)
        {
            throw new ArgumentOutOfRangeException(
                paramName: $"Oops! Please enter whole numbers dimensions"
            );
        }

        if (boardWidth is < 1 or > 40)
        {
            throw new ArgumentOutOfRangeException(
                paramName: $"Oops! Width must be between 1 and 40"
            );
        }

        if (boardHeight is < 1 or > 40)
        {
            throw new ArgumentOutOfRangeException(
                paramName: $"Oops! Height must be between 1 and 40"
            );
        }

        Console.WriteLine("How many cells should start alive? ");
        var aliveCountIsNumber = int.TryParse(Console.ReadLine(), out var aliveCount);

        if (!aliveCountIsNumber)
        {
            throw new ArgumentOutOfRangeException(paramName: $"Oops! Please enter a whole number");
        }

        if (aliveCount < 0 || aliveCount > boardWidth * boardHeight)
        {
            throw new ArgumentOutOfRangeException(
                paramName: $"Oops! Alive count must be between 0 and {boardWidth * boardHeight}"
            );
        }

        return new GameConfig
        {
            Height = boardHeight,
            Width = boardWidth,
            AliveCount = aliveCount,
        };
    }
}
