using System;
namespace MarsRoverService
{
    public class UserInterface
    {
        public int RoverX;
        public int RoverY;
        public int PlateauX;
        public int PlateauY;
        public string Roverdirection;
        public string userInputCommand;
        string userInputPlateauSize;
        public int[] grid;
        bool directionCheck;
        string userInputPositon;
        public UserInterface()
        {
        }

        public int[] GetPlateauMaxCoordinates()

        {

            do
            {
                try
                {
                    Console.WriteLine("Please enter the max coordinates of the Plateau? (Upper right cordinates in the format x y");
                    userInputPlateauSize = Console.ReadLine();
                    PlateauX = Int32.Parse(userInputPlateauSize.Split(" ")[0]);
                    PlateauY = Int32.Parse(userInputPlateauSize.Split(" ")[1]);
                }
                catch
                {
                    Console.Write("Incorrect format occurred.\n");
                }
            }
            while (PlateauX < 0 || PlateauY < 0 || userInputPlateauSize.Count() != 3);
            return grid = new int[] { PlateauX, PlateauY };
        }
        public void GetInitialRoverPostion()
        {
            do
            {
                try
                {
                    bool directionCheck;
                    Console.WriteLine("Please enter the initial  coordinates of the rover:");
                    userInputPositon = Console.ReadLine();
                    RoverX = Int32.Parse(userInputPositon.Split(" ")[0]);
                    RoverY = Int32.Parse(userInputPositon.Split(" ")[1]);
                    Roverdirection = userInputPositon.Split(" ")[2];
                    Roverdirection = Roverdirection.ToUpper();

                }
                catch
                {
                    Console.Write("Incorrect format occurred.\n");
                }
            }
            while (RoverX < 0 || RoverY < 0 || !(Roverdirection == "N" || Roverdirection == "E" || Roverdirection == "S" || Roverdirection == "W"));
        }
        public string GetRoverCommands()
        {

            do
            {
                Console.WriteLine("Please enter the command instructions for the rover:");
                userInputCommand = Console.ReadLine();
                userInputCommand = userInputCommand.ToUpper();
            }
            while (!ValidateCommand(userInputCommand));
            return userInputCommand;



        }
        bool ValidateCommand(string userInputCommand)
        {
            string commandTemplate = "LRM";
            userInputCommand = userInputCommand.ToUpper();

            foreach (char c in userInputCommand)
                if (commandTemplate.Contains(c.ToString()))

                { return true; }



            return false;
        }

    }
}


