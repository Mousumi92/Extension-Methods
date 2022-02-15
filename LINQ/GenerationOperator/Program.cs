using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Welcome to DOT NET Tutorials", 10);
            foreach (string i in repeatStrings)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
