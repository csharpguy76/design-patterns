using System;

namespace composite
{
	/// <summary>
    /// Composite Pattern demonstration.
    /// </summary>
	class MainClass
	{

		static void Main(string[] args)
        {
            // Parent 1 has two children Rosey and Greg.
            var parent1 = new Parent("David");
            parent1.AddChildren(new Child("Rosey"));
            parent1.AddChildren(new Child("Greg"));
 
            // Parent 2 has two children Jack and Jill.
            var parent2 = new Parent("Susan");
            parent2.AddChildren(new Child("Jack"));
            parent2.AddChildren(new Child("Jill"));
 
            // Parent 1 is added to parent 2 because parent 1 
            // is a child who is a parent now.
            parent2.AddChildren(parent1);
 
            // Output the parent and child hierachy.
            parent2.Print();
        }
	}
}
