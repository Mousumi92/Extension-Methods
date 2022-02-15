using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Mousumi", "Kumari" };
            IEnumerable<char> methodSyntax = nameList.SelectMany(x => x);
            foreach (char c in methodSyntax)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace LINQDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };
//            //Query syntax
//            IEnumerable<char> querySyntax = from str in nameList
//                                            from ch in str
//                                            select ch;
//            foreach (char c in querySyntax)
//            {
//                Console.Write(c + " ");
//            }
//            Console.ReadKey();
//        }
//    }
//}
