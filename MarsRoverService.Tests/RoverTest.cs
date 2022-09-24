namespace MarsRoverService.Tests;
using FluentAssertions;

public class RoverTest

{
    private Rover _rover;

    [SetUp]
    public void Setup()
    {
        _rover = new Rover(1,2,"N");
        

    }

    [Test]
    public void Given_rover_cordinates_should_rover_positon()
    {
        _rover.GetRoverPositon().Should().Be("1 2 N");
    }
}