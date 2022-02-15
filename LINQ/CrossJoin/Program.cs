using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQJoin
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetAllStudnets()
        {
            return new List<Student>()
            {
                new Student { ID = 1, Name = "Preety"},
                new Student { ID = 2, Name = "Priyanka"},
                new Student { ID = 3, Name = "Anurag"},
                new Student { ID = 4, Name = "Pranaya"},
                new Student { ID = 5, Name = "Hina"}
            };
        }
    }
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<Subject> GetAllSubjects()
        {
            return new List<Subject>()
            {
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var CrossJoinResult = from employee in Student.GetAllStudnets()
                                  from subject in Subject.GetAllSubjects()
                                  select new
                                  {
                                      Name = employee.Name,
                                      SubjectName = subject.SubjectName
                                  };
            foreach (var item in CrossJoinResult)
            {
                Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
            }
            Console.ReadLine();
        }
    }
}