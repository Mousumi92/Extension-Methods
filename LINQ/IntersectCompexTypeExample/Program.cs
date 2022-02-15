using System.Collections.Generic;
using System;
using System.Linq;
namespace LINQDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        //Once you run the application, then it will not display any data.This is because the default comparer which is used for comparison is only checked whether two object references are equal and not the individual property values of the complex object.
        static void Main(string[] args)
        {
            List<Student> StudentCollection1 = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
            };
            List<Student> StudentCollection2 = new List<Student>()
            {
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
                new Student {ID = 107, Name = "Pranaya"},
                new Student {ID = 108, Name = "Santosh"},
            };
            //Method Syntax
            var MS = StudentCollection1.Intersect(StudentCollection2).ToList();
            //Query Syntax
            var QS = (from std in StudentCollection1
                      select std).Intersect(StudentCollection2).ToList();

           // which already overrides the Equals() and GetHashCode() methods
            //Method Syntax
            //var MS = StudentCollection1.Select(x => new { x.ID, x.Name })
            //         .Intersect(StudentCollection2.Select(x => new { x.ID, x.Name })).ToList();
            //Query Syntax
            //var QS = (from std in StudentCollection1
            //          select new { std.ID, std.Name })
            //          .Intersect(StudentCollection2.Select(x => new { x.ID, x.Name })).ToList();

            foreach (var student in MS)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }

            Console.ReadKey();
        }
    }
}