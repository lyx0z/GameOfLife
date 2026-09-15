namespace GameOfLife.ConsoleUi;

public static class GameBoardSetup
{
    public static (int, int, int) GetUserInput()
    {
        Console.WriteLine("Whats going to be your board size?");

        Console.WriteLine("Width: ");
        var widthIsNumber = int.TryParse(Console.ReadLine(), out var width);

        Console.WriteLine("Height: ");
        var heightIsNumber = int.TryParse(Console.ReadLine(), out var height);

        if (!widthIsNumber || !heightIsNumber)
        {
            throw new ArgumentException(message: "Oops! Please enter whole numbers dimensions");
        }

        if (width is < 1 or > 100)
        {
            throw new ArgumentException(message: "Oops! Width must be between 1 and 100");
        }

        if (height is < 1 or > 100)
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

            aliveCount = (int)(width * height * (percent / 100));
        }
        else
        {
            var aliveCountIsNumber = int.TryParse(input, out aliveCount);

            if (!aliveCountIsNumber)
            {
                throw new ArgumentException(message: "Oops! Please enter a whole number");
            }
        }

        if (aliveCount < 0 || aliveCount > width * height)
        {
            throw new ArgumentException(
                message: "Oops! Alive count must be between 0 and {boardWidth * boardHeight}"
            );
        }

        return (width, height, aliveCount);
    }
}
