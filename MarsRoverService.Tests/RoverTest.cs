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
        _rover.GetPositon().Should().Be("1 2 N");
    }
    [Test]
    public void RoverShouldSpinLeft()
    {
      
        _rover.SpinLeft();
        _rover.direction.Should().Be("W");
    }
    [Test]
    public void RoverShouldSpinRight()
    {
        
        _rover.SpinRight();
        _rover.direction.Should().Be("E");
    }
    [Test]
    public void MoveFoward()
    {
  
        _rover.MoveFoward();
        _rover.roverPositionY.Should().Be(3);
    }

}