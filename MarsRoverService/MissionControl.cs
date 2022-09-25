using System;
namespace MarsRoverService
{
	public class MissionControl
	{
		public int roverpostioningridX;
        public int roverpostiongridY;
	
		public bool obstacle;
		


        public MissionControl()
		{
			
		}
		public void UpdateRoverPostion(Rover rover)
		{
            roverpostioningridX = rover.roverPositionX;
			roverpostiongridY = rover.roverPositionY;
		}
        public bool CheckUpadtedRoverInGrid(Plateau _plateau)
        {
			return _plateau.IsOutOfGrid(roverpostioningridX, roverpostiongridY);
        }
		

    }
}

