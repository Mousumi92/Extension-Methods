using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {10,20,30  };
           // List<int> numbers = new List<int>() { };
            IEnumerable<int> result = numbers.DefaultIfEmpty(5);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
