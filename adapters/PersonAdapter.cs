using System;

namespace adapters
{
	public class PersonAdapter : IPerson
	{
		private OldPerson oldPerson;
		private string firstName;
		private string lastName;
		
		public PersonAdapter (OldPerson oldPerson)
		{
			this.oldPerson = oldPerson;
			var fullname = this.oldPerson.GetFullName();
			this.firstName = fullname.Split(' ')[0];
			this.lastName = fullname.Split(' ')[1];
		}
		
		public string GetFirstName()
		{
			return firstName;
		}
		
		public string GetLastName()
		{
			return lastName;
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

