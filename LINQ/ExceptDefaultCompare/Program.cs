using System;
using System.Linq;
namespace LINQDemo
{
    //class program
    //{
    //    static void main(string[] args)
    //    {
    //        string[] datasource1 = { "india", "usa", "uk", "canada", "srilanka" };
    //        string[] datasource2 = { "india", "uk", "canada", "france", "japan" };
    //        //method syntax
    //        var ms = datasource1.except(datasource2).tolist();
    //        //query syntax
    //        var qs = (from country in datasource1
    //                  select country)
    //                  .except(datasource2).tolist();
    //        foreach (var item in qs)
    //        {
    //            console.writeline(item);
    //        }
    //        console.readkey();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}