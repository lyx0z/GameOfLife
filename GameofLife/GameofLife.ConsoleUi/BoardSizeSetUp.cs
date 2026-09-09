namespace GameOfLife.ConsoleUi;

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
            throw new ArgumentException(message: "Oops! Please enter whole numbers dimensions");
        }

        if (boardWidth is < 1 or > 100)
        {
            throw new ArgumentException(message: "Oops! Width must be between 1 and 100");
        }

        if (boardHeight is < 1 or > 100)
        {
            throw new ArgumentException(message: "Oops! Height must be between 1 and 100");
        }

        Console.WriteLine("How many cells should start alive?(num or %) ");
        var input = Console.ReadLine()?.Trim() ?? "";

        int aliveCount;

        if (input.EndsWith($"%"))
        {
            var isPercent = double.TryParse(input[..^1], out var percent);

            if (!isPercent)
            {
                throw new ArgumentException(message: "Oops! Please enter valid percentages");
            }

            aliveCount = (int)(boardWidth * boardHeight * (percent / 100));
        }
        else
        {
            var aliveCountIsNumber = int.TryParse(input, out aliveCount);

            if (!aliveCountIsNumber)
            {
                throw new ArgumentException(message: "Oops! Please enter a whole number");
            }
        }

        if (aliveCount < 0 || aliveCount > boardWidth * boardHeight)
        {
            throw new ArgumentException(
                message: "Oops! Alive count must be between 0 and {boardWidth * boardHeight}"
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
