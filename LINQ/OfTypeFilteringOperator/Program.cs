using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };

            List<int> intData = dataSource.OfType<int>().ToList();

            foreach (int number in intData)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<object> dataSource = new List<object>()
    //        {
    //            "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
    //        };
    //        var stringData = (from name in dataSource
    //                          where name is string
    //                          select name).ToList();
    //        foreach (string name in stringData)
    //        {
    //            Console.Write(name + " ");
    //        }

    //        Console.ReadKey();
    //    }
    //}
}