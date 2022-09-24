namespace MarsRoverService.Tests;
using FluentAssertions;

public class PlateauTest

{
    private Plateau _plateau;
    [SetUp]
    public void Setup()
    {
        int[] grid = { 5, 5 };
                 

        _plateau = new Plateau(grid);
    }

    [Test]
    public void Given_Grid_Should_Return_maxX_maxY()
    {
        _plateau.maxX.Should().Be(5);
        _plateau.maxY.Should().Be(5);
    }
    [Test]
    public void Given_Grid_Should_Return_minX_minY()
    {
        _plateau.minX.Should().Be(0);
        _plateau.minY.Should().Be(0);
    }
}