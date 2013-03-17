using System;
using System.Collections.Generic;

namespace composite
{
	public class Parent:IMember
    {
        private string _name;
 
        private List<IMember> members = new List<IMember>();
 
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the parent as a string.</param>
        public Parent(string name)
        {
            _name = name;
        }
 
        /// <summary>
        /// Print method to write the parent and the children's name to the console.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Parent: {0}", _name);
 
            foreach (var member in members)
            {
                member.Print();
            }
        }
 
        /// <summary>
        /// AddChildren method adds a new member object to the parent.
        /// </summary>
        /// <param name="member">add a parent or child</param>
        public void AddChildren(IMember member)
        {
            members.Add(member);
        }
 
        /// <summary>
        /// RemoveChildren method removed an existing member from the parent.
        /// </summary>
        /// <param name="member">remove a parent or a child</param>
        public void RemoveChildren(IMember member)
        {
            members.Remove(member);
        }
 
    }
}

