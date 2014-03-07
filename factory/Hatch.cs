using System;

namespace factory
{
	public class Hatch : ICar
	{
		public Hatch ()
		{
		}

		// Hatch class implements the ICar interface and GetPrice method.
		public decimal GetPrice()
		{
			return 15000;
		}
	}
}

