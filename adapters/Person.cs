using System;

namespace adapters
{
	public class Person : IPerson
	{
		private string firstName;
		private string lastName;
		
		public Person ()
		{
		}
	
		public string GetFirstName()
		{
			return this.firstName;
		}
		
		public string GetLastName()
		{
			return this.lastName;
		}
		
		public void SetFirstName(string firstName)
		{
			this.firstName = firstName;
		}
		
		public void SetLastName(string lastName)
		{
			this.lastName = lastName;
		}
	}
	
}

