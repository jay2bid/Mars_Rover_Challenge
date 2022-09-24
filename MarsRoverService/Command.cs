using System;
namespace MarsRoverService
{
	public class Command
	{
        
        string roverCommand;
        char[] commandMessage;
		public Command(string _roverCommand)
		{
            roverCommand = _roverCommand;

        }

        public void ExecuteCommand(Rover _rover)
        {

            commandMessage = roverCommand.ToCharArray();

            foreach (char c in commandMessage)
            {
                switch (c)
                {
                    case 'M':
                        _rover.MoveFoward();
                        break;
                    case 'L':
                        _rover.SpinLeft();
                        break;
                    case 'R':
                        _rover.SpinRight();
                        break;

                }

            }



        }
        


    }
}

