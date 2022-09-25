using MarsRoverService;


Console.WriteLine("Welcome to the Mars explorer");

UserInterface explorer = new UserInterface();

int[] grid =  explorer.GetPlateauMaxCoordinates();
Plateau mars = new Plateau(grid);
    mars.maxX = grid[0];
    mars.maxY = grid[1];

explorer.GetInitialRoverPostion();
Rover nasa = new Rover();
    nasa.x = explorer.RoverX;
    nasa.y = explorer.RoverY;
    nasa.direction = explorer.Roverdirection;
explorer.GetRoverCommands();
Command first = new Command(explorer.userInputCommand);
    first.ExecuteCommand(nasa);

Rover roscosmos = new Rover();
    explorer.GetInitialRoverPostion();
    roscosmos.x = explorer.RoverX;
    roscosmos.y = explorer.RoverY;
    roscosmos.direction = explorer.Roverdirection;
explorer.GetRoverCommands();
Command second = new Command(explorer.userInputCommand);
    second.ExecuteCommand(roscosmos);


Console.WriteLine(nasa.GetPositon());
Console.WriteLine(roscosmos.GetPositon());



