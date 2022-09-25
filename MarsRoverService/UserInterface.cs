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

        public UserInterface()
		{
		}

		public int[] GetPlateauMaxCoordinates()

		{

            Console.WriteLine("Please enter the upper right hand corner coordinates of the Plateau:");
            string userInputPlateauSize = Console.ReadLine();

            
            int[] grid;

            PlateauX = Int32.Parse(userInputPlateauSize.Split(" ")[0]);
            PlateauY = Int32.Parse(userInputPlateauSize.Split(" ")[1]);
            return grid = new int[] { PlateauX, PlateauY };
        }
        public void GetInitialRoverPostion()
        {

            Console.WriteLine("Please enter the initial  coordinates of the rover:");
            string userInputPositon = Console.ReadLine();
           RoverX = Int32.Parse(userInputPositon.Split(" ")[0]);
            RoverY = Int32.Parse(userInputPositon.Split(" ")[1]);
             Roverdirection = userInputPositon.Split(" ")[2];
            
        }
        public void GetRoverCommands()
        {

            Console.WriteLine("Please enter the command instructions for the rover:");

            userInputCommand = Console.ReadLine();
        }
    }

}

