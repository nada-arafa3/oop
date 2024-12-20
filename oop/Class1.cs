using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
   
        public class Employee
        {
          
            public int ID { get; set; }
            public string Name { get; set; }
            public string SecurityLevel { get; set; }
            public decimal Salary { get; set; }
            public DateTime HireDate { get; set; }
            public string Gender { get; set; }

            public Employee(int id, string name, string securityLevel, decimal salary, DateTime hireDate, string gender)
            {
                ID = id;
                Name = name;
                SecurityLevel = securityLevel;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }

            public void DisplayEmployeeDetails()
            {
                Console.WriteLine($"ID: {ID}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Security Level: {SecurityLevel}");
                Console.WriteLine($"Salary: {Salary}"); 
                Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
                Console.WriteLine($"Gender: {Gender}");
            }
        }
    }

