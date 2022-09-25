using MarsRoverService;
/*
int[] grid = new int[] { 5, 5 };
Plateau mars = new Plateau(grid);
Rover nasa = new Rover(1, 2, "N");
Rover russia = new Rover(3, 3, "E");
Command first = new Command("LMLMLMLMM");
first.ExecuteCommand(nasa);
Command second = new Command("MMRMMRMRRM");
second.ExecuteCommand(russia);
Console.WriteLine(russia.GetPositon());
Console.ReadLine();
*/

Console.WriteLine("Welcome to the Mars explorer");

UserInterface explorer = new UserInterface();

int[] grid =  explorer.GetPlateauMaxCoordinates();
Plateau mars = new Plateau(grid);
mars.maxX = grid[0];
mars.maxY = grid[1];
Rover nasa = new Rover();
explorer.GetInitialRoverPostion();
nasa.x = explorer.RoverX;
nasa.y = explorer.RoverY;
nasa.direction = explorer.Roverdirection;
explorer.GetRoverCommands();
Command action = new Command(explorer.userInputCommand);
action.ExecuteCommand(nasa);
Console.WriteLine(nasa.GetPositon());



/*Rover nasa = new Rover(x, y, direction);
string commandmessage;
explorer.GetRoverCommands(out commandmessage);
Command userCommand = new Command( commandmessage);
userCommand.ExecuteCommand(nasa);
Console.WriteLine(nasa.GetPositon());
*/



