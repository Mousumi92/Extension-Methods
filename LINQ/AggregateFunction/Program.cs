using System;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = skills.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}