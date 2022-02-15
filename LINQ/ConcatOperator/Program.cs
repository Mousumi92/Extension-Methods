using System.Linq;
using System;
using System.Collections.Generic;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = new List<int> {  2, 3,5,6 };
            var result = sequence1.Concat(sequence2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}