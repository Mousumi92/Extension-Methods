using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Modifiers
{
    /// <summary>
    /// A protected member is accessible from within the class in which it is declared, and from within any class derived from the class that declared this member.
    /// A protected member of a base class is accessible in a derived class only if the access takes place through the derived class type.
    /// </summary>


    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        User u = new User();
    //        // Complier Error
    //        // These are inaccessible due to protected specifier
    //        u.Name = "Suresh Dasari";
    //        u.Location = "Hyderabad";
    //        u.Age = 32;
    //        u.GetUserDetails();
    //        Console.WriteLine("\nPress Enter Key to Exit..");
    //        Console.ReadLine();
    //    }
    //}

    class Program : User
    {
        static void Main(string[] args)
        {
            User u = new User();
            Program p = new Program();
            // Complier Error
            // protected members can only accessible with derived classes
            u.Name = "Suresh Dasari";
            p.Name = "Suresh Dasari";
            p.Location = "Hyderabad";
            p.Age = 32;
            p.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
