using System;

namespace adapters
{
	public class OldPerson
	{
		private string fullName;
		
		public OldPerson()
		{
		}
		
		public void SetFullName(string fullName)
		{
			this.fullName = fullName;
		}
		
		public string GetFullName()
		{
			return this.fullName;
		}
	}
}

