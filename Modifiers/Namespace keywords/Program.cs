// C# program to illustrate how to use
// the :: Namespace Alias Qualifier
using System;

// creating aliased name
using first = firstnamespace;
using sec = secondnamespace;

namespace Geeks
{

    class GFG
    {

        // Main Method
        static void Main()
        {

            // use of Namespace alias qualifier(::)
            first::GFG1 obj1 = new first::GFG1();
            obj1.display();
        }
    }
}

// Both namespaces have a 
// class named GFG1
namespace firstnamespace
{

    class GFG1
    {

        public void display()
        {
            Console.WriteLine("It is the first namespace.");
        }
    }
}

namespace secondnamespace
{

    class GFG1
    {

        public void display()
        {
            Console.WriteLine("It is the second namespace.");
        }
    }
}