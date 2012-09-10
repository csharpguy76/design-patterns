using System;

namespace facade
{
	/// <summary>
	/// Wheels.
	/// Subsystem that adds the wheels.
	/// </summary>
	public class Wheels
	{
		public Wheels ()
		{
		}
		
		public void AddWheels(int num)
		{
			Console.WriteLine("{0} Wheels Added", num.ToString());
		}
	}
}

