using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> ResultMS = numbers.Take(4).ToList();
            int[] ResultMS1 = numbers.Take(4).Where(num => num > 2).ToArray();


            List<int> ResultMS2 = numbers.TakeWhile(num => num < 6).ToList();
            List<int> ResultMS3 = numbers.Where(num => num < 6).ToList();

            List<int> ResultMS4 = numbers.Skip(4).ToList();
            List<int> ResultQS = (from num in numbers
                                  select num).Skip(4).ToList();

            int[] ResultMS6 = numbers.Where(num => num > 3).Skip(4).ToArray();

            List<int> numbers1 = new List<int>() { 1, 4, 5, 6, 7, 8, 9, 10, 2, 3 };
            List<int> ResultMSS = numbers.SkipWhile(num => num < 5).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }
    }
}
