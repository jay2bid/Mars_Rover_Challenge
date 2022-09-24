using System;
namespace MarsRoverService
{
	public class MissionControl
	{
		public int roverpostioningridX;
        public int roverpostiongridY;
		public Plateau _plateau;
		public bool obstacle;
		


        public MissionControl()
		{
			
		}
		public void UpdateRoverPostion(Rover rover)
		{
            roverpostioningridX = rover.x;
			roverpostiongridY = rover.y;
		}
        public bool GridBoundary()
        {
			return true;
        }
		

    }
}

