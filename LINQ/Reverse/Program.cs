using System.Collections.Generic;
using System;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };
            Console.WriteLine("Before Reverse the Data");
            foreach (var name in stringList)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            IEnumerable<string> ReverseData1 = stringList.AsEnumerable().Reverse();
            IQueryable<string> ReverseData2 = stringList.AsQueryable().Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var name in ReverseData1)
            {
                Console.Write(name + " ");
            }
            Console.ReadKey();




            // List<string> stringList = new List<string>() { "Preety", "Tiwary", "Agrawal", "Priyanka", "Dewangan" };

            // Console.WriteLine("Before Reverse the Data");
            // foreach (var name in stringList)
            // {
            //     Console.Write(name + " ");
            // }
            // Console.WriteLine();
            // //You cannot store the data like below as this method belongs to
            // //System.Collections.Generic namespace whose return type is void
            //// IEnumerable<int> ArrayReversedData = stringList.Reverse();
            // stringList.Reverse();
            // Console.WriteLine("After Reverse the Data");
            // foreach (var name in stringList)
            // {
            //     Console.Write(name + " ");
            // }
            // Console.ReadKey();
        }
    }
}