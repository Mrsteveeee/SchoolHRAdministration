using System;
using HRAdministrationAPI;
using System.Collections.Generic;
using System.Linq;
using static SchoolHRAdministration.Program;

namespace SchoolHRAdministration
{
    public class Program
    {
        public enum EmployeeType
        {
            Teacher,
            HeadOfDepartment,
            DeputyHeadMaster,
            HeadMaster
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

    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            IEmployee employee = null;

            switch (employeeType) 
            {
                case EmployeeType.Teacher:
                    employee = new Teacher
                    {
                        ID = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment
                    {
                        ID = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = new DeputyHeadMaster
                    {
                        ID = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;
                case EmployeeType.HeadMaster:
                    employee = new HeadMaster
                    {
                        ID = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Salary = salary
                    };
                    break;

                default:
                    break;
            }

            return employee;
        }
    }
}