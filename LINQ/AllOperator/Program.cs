using System;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = { 7, 9, 8, 2, 3 };
            var Result = IntArray.Any(x => x > 10);
            //Using Query Syntax
            var ResultQS = (from num in IntArray
                            select num).All(x => x > 10);


            ////Using Method Syntax
            //var ResultMS = IntArray.Any();
            ////Using Query Syntax
            //var ResultQS = (from num in IntArray
            //                select num).Any();

            Console.WriteLine("Is All Numbers are greater than 10 : " + Result);
            Console.ReadKey();
        }
    }
}