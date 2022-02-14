using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class StudentHelper
    {
        public static string GetUpperName(this Student student) // Using this before Student class  
        {
            return student.name.ToUpper();
        }
    }
    public class Student
    {
        public string name = "Mousumi";
        public string GetName()
        {
            return this.name;
        }
    }
    public class ExtensionMethodExample
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetUpperName());
        }
    }
}