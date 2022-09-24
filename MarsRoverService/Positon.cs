using System;
namespace MarsRoverService
{
	public class Positon
	{
        public int X { get; set; }
        public int Y { get; set; }
      
        
        public Positon(int x, int y)
		{
            // initialise position co-ordinates
            X = x;
            Y = y;
        }
	}
}

