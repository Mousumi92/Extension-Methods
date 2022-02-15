using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQJoin
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", AddressId = 1},
                new Employee { ID = 2, Name = "Priyanka", AddressId =2},
                new Employee { ID = 3, Name = "Anurag", AddressId = 0},
                new Employee { ID = 4, Name = "Pranaya", AddressId = 0},
                new Employee { ID = 5, Name = "Hina", AddressId = 5},
                new Employee { ID = 6, Name = "Sambit", AddressId = 6}
            };
        }
    }
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAddress()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 6, AddressLine = "AddressLine6"},
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var QSOuterJoin = from emp in Employee.GetAllEmployees()
                              join add in Address.GetAddress()
                              on emp.AddressId equals add.ID
                              into EmployeeAddressGroup
                              from address in EmployeeAddressGroup.DefaultIfEmpty()
                              select new { emp, address };

            var MSOuterJOIN = Employee.GetAllEmployees()
                              .GroupJoin(
                                    Address.GetAddress(),
                                    emp => emp.AddressId,
                                    add => add.ID,
                                    (emp, add) => new { emp, add }
                              )
                              .SelectMany(
                                    x => x.add.DefaultIfEmpty(),
                                    (employee, address) => new { employee, address }
                               );
            foreach (var item in QSOuterJoin)
            {
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            }
            Console.ReadLine();
        }
    }
}