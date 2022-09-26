using MarsRoverService;


Console.WriteLine("Welcome to the Mars explorer!");

UserInterface session = new UserInterface();
MissionControl mission = new MissionControl();

int[] grid = session.GetPlateauMaxCoordinates();
Plateau mars = new Plateau(grid);
mars.maxX = grid[0];
mars.maxY = grid[1];


session.GetInitialRoverPostion();
Rover nasa = new Rover();
nasa.roverPositionX = session.RoverX;
nasa.roverPositionY = session.RoverY;
nasa.direction = session.Roverdirection;
string command = session.GetRoverCommands();



Command first = new Command(session.userInputCommand);
first.ExecuteCommand(nasa);

Rover roscosmos = new Rover();
session.GetInitialRoverPostion();
roscosmos.roverPositionX = session.RoverX;
roscosmos.roverPositionY = session.RoverY;
roscosmos.direction = session.Roverdirection;
session.GetRoverCommands();
Command second = new Command(session.userInputCommand);
second.ExecuteCommand(roscosmos);

Console.WriteLine("The Rovers have moved to these positions:");
Console.WriteLine(nasa.GetPositon());
Console.WriteLine(roscosmos.GetPositon());





