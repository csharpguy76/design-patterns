using System;

namespace adapters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Create an OldPerson that only allows a full name string.
			var oldPerson = new OldPerson();
			oldPerson.SetFullName("Joe Bloggs");
			
			Console.WriteLine ("OldPerson Full Name: {0}", oldPerson.GetFullName());
			
			// Adapter will convert the OldPerson full name into seperate
			// firstname and lastname strings.
			var personAdapter = new PersonAdapter(oldPerson);
			
			// Create a new Person and set the first and last name.
			var person = new Person();
			person.SetFirstName(personAdapter.GetFirstName());
			person.SetLastName(personAdapter.GetLastName());
			
			Console.WriteLine ("Person First Name: {0} Last Name: {1}", person.GetFirstName(), person.GetLastName());
		}
	}
}
