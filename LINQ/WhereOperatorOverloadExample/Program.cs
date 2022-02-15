using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method Syntax
            var OddNumbersWithIndexPosition = intList.Select((num, index) => new
            {
                Numbers = num,
                IndexPosition = index
            }).Where(x => x.Numbers % 2 != 0)
                                                .Select(data => new
                                                {
                                                    Number = data.Numbers,
                                                    IndexPosition = data.IndexPosition
                                                });

            foreach (var item in OddNumbersWithIndexPosition)
            {
                Console.WriteLine($"IndexPosition :{item.IndexPosition} , Value : {item.Number}");
            }
            Console.ReadKey();
        }
    }
}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //        //Query Syntax
    //        var OddNumbersWithIndexPosition = from number in intList.Select((num, index) => new { Numbers = num, IndexPosition = index })
    //                                          where number.Numbers % 2 != 0
    //                                          select new
    //                                          {
    //                                              Number = number.Numbers,
    //                                              IndexPosition = number.IndexPosition
    //                                          };

    //        foreach (var item in OddNumbersWithIndexPosition)
    //        {
    //            Console.WriteLine($"IndexPosition :{item.IndexPosition} , Value : {item.Number}");
    //        }
    //        Console.ReadKey();
    //    }
    //}
}