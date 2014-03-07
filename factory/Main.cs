using System;

namespace factory
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Client client = new Client();
			decimal totalCost = client.Buy("sedan", 2);
			Console.WriteLine ("Client purchased 2 sedan for the price of {0}", totalCost);
		}
	}
}
