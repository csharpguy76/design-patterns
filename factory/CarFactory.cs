using System;

namespace factory
{
	public static class CarFactory
	{
		// Factory method GetCar sole purpose is producing different type
		// of cars and return the new object to the client.
		public static ICar GetCar(string carType)
		{
			ICar car = null;
			switch (carType) 
			{
			case "sedan":
				car = new Sedan();
				break;
			case "hatch":
				car = new Hatch();
				break;
			}
			return car;
		}
	}
}

