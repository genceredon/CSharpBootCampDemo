using Module03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03.Modifiers
{
    public class Employee
    {
        //Global declaration
        EmployeeDetails defaultEmployee = new EmployeeDetails();

        //Constructor
        public Employee()
        {
            Console.WriteLine("Inside Employee constructor");
        }

        public Employee(string firstName, string lastName, string age)
        {
            defaultEmployee = new EmployeeDetails();
            defaultEmployee.FirstName = firstName;
            defaultEmployee.LastName = lastName;
            defaultEmployee.Age = age;
            
            //   var defaultEmployee = new EmployeeDetails()
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Age = age
            //};
        }

        public void SetEmployeeInfo()
        {
            var empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails
                {
                    FirstName = "Juan",
                    LastName = "Dela Cruz",
                    Gender = "Male",
                    Age = "30",
                    Address = "Makati City",
                    ContactNumber = "12345"
                },

                new EmployeeDetails
                {
                    FirstName = "Gen",
                    LastName = "Dela Cruz",
                    Gender = "Male",
                    Age = "30",
                    Address = "Makati City",
                    ContactNumber = "12345"
                },

                new EmployeeDetails
                {
                    FirstName = "Joy",
                    LastName = "Dela Cruz",
                    Gender = "Male",
                    Age = "30",
                    Address = "Makati City",
                    ContactNumber = "12345"
                }
            };

            var emp1Details = new EmployeeDetails()
            {
                FirstName = "Juan",
                LastName = "Dela Cruz",
                Gender = "Male",
                Age = "30",
                Address = "Makati City",
                ContactNumber = "12345"
            };

            var emp2Detail = new EmployeeDetails();
            emp2Detail.FirstName = "Gen";
            emp2Detail.LastName = "Ceredon";
            emp2Detail.Age = "16";
            emp2Detail.Gender = "Female";
            emp2Detail.Address = "Laguna";
            emp2Detail.ContactNumber = "0987654321";

            //Constructor with parameters
            
            DisplayEmployeeDetails(defaultEmployee);
            
            Employee emp = new Employee();
            emp.DisplayEmployeeDetails(empDetails);
            emp.DisplayEmployeeDetails(emp2Detail);       
        }

        private void DisplayEmployeeDetails(List<EmployeeDetails> employee)
        {
            foreach (var item in employee)
            {
                Console.WriteLine($"Employee FirstName: {item.FirstName}");
                Console.WriteLine($"Employee LastName: {item.LastName}");
                Console.WriteLine($"Employee Gender: {item.Gender}");
                Console.WriteLine($"Employee Age: {item.Age}");
                Console.WriteLine($"Employee ContactNumber: {item.ContactNumber}");
                Console.WriteLine($"Employee Address: {item.Address}");
                Console.WriteLine("=======================================================");
            }
        }

        private void DisplayEmployeeDetails(EmployeeDetails employee)
        {
            Console.WriteLine($"Employee Firstname: {employee.FirstName}");
            Console.WriteLine($"Employee Lastname: {employee.LastName}");
            Console.WriteLine($"Employee Gender: {employee.Gender}");
            Console.WriteLine($"Employee Age: {employee.Age}");
            Console.WriteLine($"Employee Address: {employee.Address}");
            Console.WriteLine($"Employee Contact Number: {employee.ContactNumber}");
        }      
    }
}
