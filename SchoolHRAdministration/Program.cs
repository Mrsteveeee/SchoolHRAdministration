using System;
using HRAdministrationAPI;
using System.Collections.Generic;

namespace SchoolHRAdministration
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal totalSalary = 0;
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            foreach (IEmployee employee in employees)
            { 
                totalSalary += employee.Salary;
            }
            Console.WriteLine($"Total Salary of all employees(Including bonuses): {totalSalary}");

            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                ID = 1,
                FirstName = "John",
                LastName = "Doe",
                Salary = 50000
            };

            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                ID = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Salary = 55000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                ID = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                Salary = 60000,
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                ID = 4,
                FirstName = "Bob",
                LastName = "Brown",
                Salary = 65000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                ID = 5,
                FirstName = "Charlie",
                LastName = "Davis",
                Salary = 70000
            };

            employees.Add(headMaster);
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary + 0.02m);}
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary + 0.03m); }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary + 0.04m); }
    }
    
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary + 0.05m); }
    }
}