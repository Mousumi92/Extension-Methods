using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList
            {
                10,
                20,
                30,
                "50"
            };
            //IEnumerable<int> result = list.Cast<int>();
            IEnumerable<int> result = list.OfType<int>();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
