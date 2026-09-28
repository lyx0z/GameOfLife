namespace GameOfLife.WebUi.Pages;

using Core;

public partial class GameBoard : IDisposable
{
    private int height = 20;
    private int width = 20;
    private int aliveCount = 100;

    private CancellationTokenSource? cancellationTokenSource;
    private Game? game;
    private bool[,]? cells;

    private async Task OnConfigSubmit()
    {
        if (cancellationTokenSource != null)
        {
            await cancellationTokenSource.CancelAsync();
            cancellationTokenSource.Dispose();
        }

        cancellationTokenSource = new CancellationTokenSource();
        game = new Game(width, height, aliveCount);
        await Start(cancellationTokenSource.Token);
    }

    private async Task Start(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            cells = game!.GetNextFrame();
            StateHasChanged();
            await Task.Delay(200, token);
        }
    }

    private void Stop()
    {
        cancellationTokenSource?.Cancel();
        cancellationTokenSource?.Dispose();
        cancellationTokenSource = null;
    }

    private async Task Resume()
    {
        if (cancellationTokenSource is null)
        {
            cancellationTokenSource = new CancellationTokenSource();
            await Start(cancellationTokenSource.Token);
        }
    }

    private void SwapState(int cellId)
    {
        var totalWidth = cellId % width;
        var totalHeight = cellId / width;
        game!.SwapState(totalWidth, totalHeight);
    }

    public void Dispose()
    {
        cancellationTokenSource?.Dispose();
        cancellationTokenSource = null;
    }
}
