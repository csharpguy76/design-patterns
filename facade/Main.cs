using System;

namespace facade
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var car = new Car();
			car.BuildCar();
		}
	}
}
