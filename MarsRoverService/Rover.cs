﻿using System;
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

        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;

            }

        }
        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;

            }

        }
        public void MoveFoward()
        {
            switch (direction)
            {
                case "N":
                    y++;
                    break;
                case "E":
                    x++;
                    break;
                case "S":
                    y--;
                    break;
                case "W":
                    x--;
                    break;

            }
        }

    }
}

