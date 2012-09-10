using System;

namespace facade
{
	/// <summary>
	/// The Car class is a complex system that uses a Facade Pattern which contains 
	/// several sub systems that will perform different processes.
	/// </summary>
	public class Car
	{
		private Body body;
		private Engine engine;
		private Seats seats;
		private Wheels wheels;
		
		/// <summary>
		/// Constructor instantiates all the subsystem or class.
		/// </summary>
		public Car ()
		{
			body = new Body();
			engine = new Engine();
			seats = new Seats();
			wheels = new Wheels();
		}
		
		/// <summary>
		/// The BuildCar method will wrap all the sub system methods
		/// into one method to build a car.
		/// </summary>
		public void BuildCar()
		{
			Console.WriteLine ("Building a car.");
			body.AddBody(BodyType.Sedan);
			engine.AddEngine(6);
			seats.AddSeats(4);
			wheels.AddWheels(4);
			Console.WriteLine("Car is complete.");
		}
	}
}

