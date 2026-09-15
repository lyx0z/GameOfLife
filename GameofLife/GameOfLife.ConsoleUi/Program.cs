using GameOfLife.Core;

namespace GameOfLife.ConsoleUi;

internal static class Program
{
    internal static void Main()
    {
        var (width, height, aliveCount) = GameBoardSetup.GetUserInput();
        var game = new Game(width, height, aliveCount);
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            Renderer.PrintBoard(game.GetNextFrame());
            Thread.Sleep(millisecondsTimeout: 100);
        }
    }
}
