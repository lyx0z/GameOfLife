using GameOfLife.Core;

namespace GameOfLife.Test.Units;

public class RulesTest
{
    [Test]
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsAliveAndHasNoNeighbour()
    {
        // Arrange
        var board = new[,]
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
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsAliveAndHasOneNeighbour()
    {
        // Arrange
        var board = new bool[,]
        {
            { false, false, false },
            { false, true, true },
            { false, false, false },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsAliveAndHasTwoNeighbours()
    {
        // Arrange
        var board = new bool[,]
        {
            { true, false, false },
            { false, true, true },
            { false, false, false },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.True);
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
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsNotAliveAndHasThreeNeighbours()
    {
        // Arrange
        var board = new bool[,]
        {
            { false, false, false },
            { true, false, true },
            { false, true, false },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsNotAliveAndHasMoreThenThreeNeighbours()
    {
        // Arrange
        var board = new bool[,]
        {
            { false, false, false },
            { true, false, true },
            { true, true, false },
        };
        // Act
        var nextGen = Rules.ComputeNextMove(board);
        var result = nextGen[1, 1];
        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void ComputeNextMove_TargetCellIsFalseWhenTargetCellIsNotAliveAndHasLessThenThreeNeighbours()
    {
        // Arrange
        var board = new bool[,]
        {
            { false, false, false },
            { false, false, false },
            { true, true, false },
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
        board[1, 1] = true;
        board[0, 1] = true;
        board[1, 2] = true;
        board[2, 2] = true;

        // Act
        var neighbourSum = Rules.GetAliveNeighborCount(board, 1, 1);

        // Assert
        Assert.That(neighbourSum, Is.EqualTo(3));
    }
}
