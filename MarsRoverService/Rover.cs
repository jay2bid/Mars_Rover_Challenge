using System;
namespace MarsRoverService
{
    public class Rover : IVehicle
    {
        public int roverPositionX;

        public int roverPositionY;
        public string direction;
        public string roverPosition;

        public Rover(int _x, int _y, string _directon)
        {

            roverPositionX = _x;
            roverPositionY = _y;
            direction = _directon;



        }
        public Rover()
        {




        }
        public string GetPositon()

        {
            roverPosition = roverPositionX + " " + roverPositionY + " " + direction;
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
                    roverPositionY++;
                    break;
                case "E":
                    roverPositionX++;
                    break;
                case "S":
                    roverPositionY--;
                    break;
                case "W":
                    roverPositionX--;
                    break;

            }
        }

    }
}

