using System;

namespace factory
{
	public class Client
	{
		public Client ()
		{
		}

		// Client method Buy() specifies the type of car and quantity 
		// and calculates the total cost. In the future if there is addition car class
		// created the only code that needs to change is the CarFactory and 
		// it shouldn't affect the client.
		public decimal Buy(string carType, int qty)
		{
			ICar car = CarFactory.GetCar(carType);
			decimal price = car.GetPrice();
			return price * qty; 
		}
	}
}

