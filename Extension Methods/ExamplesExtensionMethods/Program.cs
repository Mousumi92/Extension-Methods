using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesExtensionMethods
{
    public static class MyExtensions
    {
        //Extending integer type
        public static int GetSumOfX(this int i)
        {
            return i * (i + 1) / 2;
        }
        //Extending string type

        public static int GetTotalWords(this string s)
        {
            return s.Split(' ').Length;
        }
        //Extending Employee type

        public static string GetFullName(this Employee e)
        {
            return e.GetFirstName() + " " + e.GetLastName();
        }
    }
    public class Employee
    {
        public string GetFirstName()
        {
            return "Srinivasa Rao";
        }

        public string GetLastName()
        {
            return "Dhulipalla";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int totalSum = num.GetSumOfX(); //returns 5050



            string sentence = "This is a string data type";
            int totalWords = sentence.GetTotalWords(); //returns 6
            //static syntax
            MyExtensions.GetTotalWords(sentence);



            Employee emp = new Employee();

            string fullName = emp.GetFullName(); //returns firstName+lastName


        }
    }
}
