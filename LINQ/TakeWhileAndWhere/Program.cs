using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeWhileAndWhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
           // List<int> Result3 = numbers.Skip(5).ToList();
            List<int> Result1 = numbers.SkipWhile(num => num < 6).ToList();
            List<string> names = new List<string>() { "Sara", "Rahul", "John", "Pam", "Priyanka" };
            List<string> namesResult = names.TakeWhile((name, index) => name.Length > index).ToList();


            //Console.Write("Result Of TakeWhile Method: ");
            //foreach (var num in Result1)
            //{
            //    Console.Write($"{ num} ");
            //}
            Console.WriteLine();
            //Using Where Method
            List<int> Result2 = numbers.Where(num => num < 6).ToList();
            //Console.Write("Result Of Where Method: ");
            //Console.Write(Result3);
            foreach (var num in Result1)
            {
                Console.Write($"{ num} ");
            }
            Console.ReadKey();
        }
    }
}
