using System;
namespace MarsRoverService
{
	public class Rover
	{
        public int x;
        public int y;
        public string direction;
        public string roverPosition;

        public Rover(int _x, int _y, string _directon)
		{

            x = _x;
            y = _y;
            direction = _directon;


        }
        public string GetRoverPositon()

        {
            roverPosition = x + " " + y + " " + direction;
            return roverPosition;
        }
}
}

