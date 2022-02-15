using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };
            return listStudents;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var MS = Student.GetAllStudents().OrderBy(x => x.Branch).ToList();
            //Query Syntax
            var QS = (from std in Student.GetAllStudents()
                      orderby std.Branch
                      select std);
            foreach (var student in MS)
            {
                Console.WriteLine(" Branch: " + student.Branch + ", Name :" + student.FirstName + " " + student.LastName);
            }

            Console.ReadKey();
        }
    }
}