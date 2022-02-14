using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Access_Modifiers
{
    class User
    {
        private string Name;
        private string Location;
        private int Age;
        private void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            // Complier Error
            // These are inaccessible due to private specifier
            //u.Name = "Suresh Dasari";
            //u.Location = "Hyderabad";
            //u.Age = 32;
            //u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
