using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQJoin
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", DepartmentId = 10},
                new Employee { ID = 2, Name = "Priyanka", DepartmentId =20},
                new Employee { ID = 3, Name = "Anurag", DepartmentId = 30},
                new Employee { ID = 4, Name = "Pranaya", DepartmentId = 30},
                new Employee { ID = 5, Name = "Hina", DepartmentId = 20},
                new Employee { ID = 6, Name = "Sambit", DepartmentId = 10},
                new Employee { ID = 7, Name = "Happy", DepartmentId = 10},
                new Employee { ID = 8, Name = "Tarun", DepartmentId = 0},
                new Employee { ID = 9, Name = "Santosh", DepartmentId = 10},
                new Employee { ID = 10, Name = "Raja", DepartmentId = 20},
                new Employee { ID = 11, Name = "Ramesh", DepartmentId = 30}
            };
        }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
                {
                    new Department { ID = 10, Name = "IT"},
                    new Department { ID = 20, Name = "HR"},
                    new Department { ID = 30, Name = "Sales"  },
                };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Group Join using Method Syntax
            var GroupJoinMS = Department.GetAllDepartments().
                GroupJoin(
                    Employee.GetAllEmployees(),
                    dept => dept.ID,
                    emp => emp.DepartmentId,
                    (dept, emp) => new { dept, emp }
                );

            var GroupJoinQS = from dept in Department.GetAllDepartments()
                              join emp in Employee.GetAllEmployees()
                              on dept.ID equals emp.DepartmentId
                              into EmployeeGroups
                              select new { dept, EmployeeGroups };

            //Printing the Result set
            //Outer Foreach is for all department
            foreach (var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a department
                foreach (var employee in item.emp)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
