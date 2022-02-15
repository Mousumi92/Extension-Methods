using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                new Student(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                new Student(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Using Method Syntax
            List<string> MethodSyntax = Student.GetStudents().SelectMany(std => std.Programming).ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
                                              from program in std.Programming
                                              select program;
            //Printing the values
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }
            Console.ReadKey();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Using Method Syntax
    //        var MethodSyntax = Student.GetStudents()
    //                                    .SelectMany(std => std.Programming,
    //                                         (student, program) => new
    //                                         {
    //                                             StudentName = student.Name,
    //                                             ProgramName = program
    //                                         }
    //                                         )
    //                                    .ToList();
    //        //Using Query Syntax
    //        var QuerySyntax = (from std in Student.GetStudents()
    //                           from program in std.Programming
    //                           select new
    //                           {
    //                               StudentName = std.Name,
    //                               ProgramName = program
    //                           }).ToList();
    //        //Printing the values
    //        foreach (var item in QuerySyntax)
    //        {
    //            Console.WriteLine(item.StudentName + " => " + item.ProgramName);
    //        }
    //        Console.ReadKey();
    //    }
    //}
}


