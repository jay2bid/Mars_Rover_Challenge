using System;
namespace MarsRoverService
{
	public interface IVehicle
	{

        public string GetPositon();
        public void SpinLeft();
        public void SpinRight();
        public void MoveFoward();

    }
}

