using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Access_Modifiers
{
    class User
    {
        public string Name;
        public string Location;
        public int Age;
        public void GetUserDetails()
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
            u.Name = "Suresh Dasari";
            u.Location = "Hyderabad";
            u.Age = 32;
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
