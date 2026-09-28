namespace GameOfLife.WebUi.Pages;

using Core;

public partial class GameBoard
{
    private int height = 20;
    private int width = 20;
    private int aliveCount = 100;

    private bool isRunning;
    private Game? game;
    private bool[,]? cells;

    private async Task OnConfigSubmit()
    {
        isRunning = false;
        game = new Game(width, height, aliveCount);
        await Start();
    }

    private async Task Start()
    {
        if (isRunning)
            return;
        isRunning = true;

        while (isRunning)
        {
            cells = game!.GetNextFrame();
            StateHasChanged();
            await Task.Delay(200);
        }
    }

    private void Stop() => isRunning = false;

    private void SwapState(int cellId)
    {
        var totalWidth = cellId % width;
        var totalHeight = cellId / width;
        game!.SwapState(totalWidth, totalHeight);
    }
}
