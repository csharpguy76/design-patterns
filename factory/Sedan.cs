using System;

namespace factory
{
	public class Sedan : ICar
	{
		public Sedan ()
		{
		}

		// Sedan class implements the ICar interface and GetPrice method.
		public decimal GetPrice()
		{
			return 20000;
		}
	}
}

