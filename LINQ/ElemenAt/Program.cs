using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemenAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           // List<int> numbersEmpty = new List<int>() { };
          // int MethodSyntax = numbers.ElementAt(10);
          //  int MethodSyntax = numbers.ElementAtOrDefault(5);
           // int MethodSyntax = numbersEmpty.First();
           // int MethodSyntax = numbersEmpty.FirstOrDefault();

          // List<int> numbers = new List<int>() { 10,20};
           List<int> numbersEmpty = new List<int>() { };
            int number = numbersEmpty.Single();
            //int number = numbersEmpty.SingleOrDefault();
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
