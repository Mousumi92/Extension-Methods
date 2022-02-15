using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>() { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Using Method Syntax
            //This method belongs to System.Collections.Generic namespace
            var IsExistsMS1 = namesList.Contains("Anurag");
            //This method belongs to System.Linq namespace
            var IsExistsMS2 = namesList.AsEnumerable().Contains("Anurag");
            //Using Query Syntax
            var IsExistsQS = (from num in namesList
                              select num).Contains("Anurag");
            Console.WriteLine(IsExistsQS);
            Console.ReadKey();
        }
    }
}
