using System;

namespace facade
{
	/// <summary>
	/// Seats.
	/// Subsystem that adds the seats.
	/// </summary>
	public class Seats
	{
		public Seats ()
		{
		}
		
		public void AddSeats(int num)
		{
			Console.WriteLine("{0} Seats Added", num.ToString());
		}
	}
}

