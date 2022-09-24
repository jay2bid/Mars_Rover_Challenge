using System;
using System.Runtime.Intrinsics.X86;

namespace MarsRoverService
{
	public class Plateau
	{
        public int[] gridSize;
        public int maxX;
        public int maxY;
        public int minX = 0;
        public int minY = 0;


        public Plateau(int[] grid)
		{

            gridSize = grid;
            maxX = grid[0];
            maxY = grid[1];
            

        }
	}
}

