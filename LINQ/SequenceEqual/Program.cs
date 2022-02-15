using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cityList1 = new List<string> {"mumbai", "Hyderabad", "DELHI" };
            List<string> cityList2 = new List<string> { "delhi", "MUMBAI", "Hyderabad" };
            bool IsEqual = cityList1.SequenceEqual(cityList2);
            Console.WriteLine(IsEqual);
            Console.ReadLine();
        }
    }
}
