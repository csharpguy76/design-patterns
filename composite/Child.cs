using System;

namespace composite
{
	/// <summary>
    /// This is a class that represents a child from the composite pattern.
    /// </summary>
    public class Child:IMember
    {
        private string _name;
 
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">member's name as a string.</param>
        public Child(string name)
        {
            _name = name;
        }
 
        /// <summary>
        /// Print method write the name of the child to the console.
        /// </summary>
        public void Print()
        {

            Console.WriteLine("Child: {0}", _name);
        }
    }
}

