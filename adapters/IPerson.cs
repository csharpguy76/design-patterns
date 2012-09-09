using System;

namespace adapters
{
	public interface IPerson
	{
		string GetFirstName();
		string GetLastName();
		void SetFirstName(string firstName);
		void SetLastName(string lastName);
	}
}

