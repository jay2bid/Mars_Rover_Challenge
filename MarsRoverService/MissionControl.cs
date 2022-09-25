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
            roverpostioningridX = rover.x;
			roverpostiongridY = rover.y;
		}
        public bool CheckUpadtedRoverInGrid(Plateau _plateau)
        {
			return _plateau.IsOutOfGrid(roverpostioningridX, roverpostiongridY);
        }
		

    }
}

