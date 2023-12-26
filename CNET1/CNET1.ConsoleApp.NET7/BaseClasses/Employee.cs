// Ignore Spelling: CNET

using CNET1.ConsoleApp.NET7.Interfaces;
using CNET1.ConsoleApp.NET7.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET1.ConsoleApp.NET7.BaseClasses
{
    public class Employee : IPerson
    {
        public Employee()
        {

        }
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = new System.Random().Next(1, 10);
        }
        public Employee(string firstName, string lastName, int employeeId)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = employeeId;
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Id { get; set; }
        public Age? Age { get; set; }
        public int? EmployeeId { get; set; }
        public DateOnly? StartDate { get; set; }
        public TimeOnly? ShiftStartTime { get; set; }
    }
}
