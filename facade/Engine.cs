using System;

namespace facade
{
	/// <summary>
	/// Engine.
	/// Subsystem that adds the engine.
	/// </summary>
	public class Engine
	{
		public Engine ()
		{
		}
		
		public void AddEngine(int cyclinders)
		{
			Console.WriteLine("{0} Cylinder Engine Added", cyclinders.ToString());
		}
	}
}

