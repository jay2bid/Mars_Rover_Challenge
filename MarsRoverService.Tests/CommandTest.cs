namespace MarsRoverService.Tests;
using FluentAssertions;

public class CommandTest

{
    private Command _command;
    private Rover _rover;

    [SetUp]
    public void Setup()
    {
        _rover = new Rover(1, 2, "N");
        _command = new Command("LMLMLMLMM");

    }
    [Test]
    public void Moveto1_3_N()
    {
        _command.ExecuteCommand(_rover);
        _rover.GetRoverPositon().Should().Be("1 3 N");
       
        
    }

}
   
 