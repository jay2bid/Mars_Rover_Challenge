using System;
namespace MarsRoverService
{
	public class MissionControl
	{
		public int RoverPostionInGridX;
        public int RoverPostionInGridY;
		public string RoverDirectionInGrid;
		Rover roverCheck = new Rover();


        public bool obstacle;
		Command commandCheck = new Command();

		


        public MissionControl()
		{
			
		}
		public void UpdateRoverPostion(Rover rover)
		{
            RoverPostionInGridX = rover.roverPositionX;
            RoverPostionInGridY = rover.roverPositionY;
			RoverDirectionInGrid = rover.direction;

        }
        public bool CheckForObstacles(Plateau mars)
        {
			return true;
        }

        


    }
}

