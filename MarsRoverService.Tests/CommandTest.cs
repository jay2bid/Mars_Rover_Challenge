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
        _command = new Command();


    }

    
}
   
 