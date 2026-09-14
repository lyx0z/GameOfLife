namespace GameOfLife.Test.Units;

using GameOfLife;

public class RulesTest
{
    [Test]
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsAliveAndHasNoNeighbour()
    {
        // Arrange
        var board = new bool[,]
        {
            { false, false, false },
            { false, true, false },
            { false, false, false },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void ComputeNextMove_TargetCellIsTrueWhenTargetCellIsAliveAndHasThreeNeighbours()
    {
        // Arrange
        var board = new bool[,]
        {
            { true, true, false },
            { false, true, false },
            { false, false, true },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsAliveAndHasFourNeighbours()
    {
        // Arrange
        var board = new bool[,]
        {
            { true, true, true },
            { false, true, false },
            { false, false, true },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void GetAliveNeighborCount_ReturnsThreeNeighbourSum()
    {
        // Arrange
        var board = new bool[3, 3];
        var row = 1;
        var col = 1;
        board[1, 1] = true;
        board[0, 1] = true;
        board[1, 2] = true;
        board[2, 2] = true;

        // Act
        var neighbourSum = Rules.GetAliveNeighborCount(board, row, col);

        // Assert
        Assert.That(neighbourSum, Is.EqualTo(3));
    }
}
