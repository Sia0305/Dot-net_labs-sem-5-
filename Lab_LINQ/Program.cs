using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
        public List<string> Skills { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>{
       new Department { DeptId = 1, DeptName = "HR" },
    new Department { DeptId = 2, DeptName = "IT" },
    new Department { DeptId = 3, DeptName = "Finance" },
    new Department { DeptId = 4, DeptName = "Marketing" }
};

            var employees = new List<Employee>
{
    new Employee { Id = 101, Name = "Amit",   Age = 28, Salary = 75000, DeptId = 2, Skills = new List<string>{ "C#", "SQL", "Angular" } },
    new Employee { Id = 102, Name = "Neha",   Age = 34, Salary = 95000, DeptId = 2, Skills = new List<string>{ "Java", "C#", "React" } },
    new Employee { Id = 103, Name = "Raj",    Age = 45, Salary = 60000, DeptId = 1, Skills = new List<string>{ "Excel", "Communication" } },
    new Employee { Id = 104, Name = "Priya",  Age = 29, Salary = 82000, DeptId = 3, Skills = new List<string>{ "Accounting", "SQL" } },
    new Employee { Id = 105, Name = "Karan",  Age = 31, Salary = 88000, DeptId = 2, Skills = new List<string>{ "C#", "Azure", "Docker" } },
    new Employee { Id = 106, Name = "Simran", Age = 26, Salary = 72000, DeptId = 4, Skills = new List<string>{ "Design", "Photoshop" } },
    new Employee { Id = 107, Name = "Rohan",  Age = 38, Salary = 92000, DeptId = 5, Skills = new List<string>{ "Salesforce", "Communication", "Excel" } },
    new Employee { Id = 108, Name = "Sneha",  Age = 27, Salary = 68000, DeptId = 1, Skills = new List<string>{ "Recruitment", "Communication", "Excel" } },
    new Employee { Id = 109, Name = "Vikram", Age = 40, Salary = 98000, DeptId = 3, Skills = new List<string>{ "Accounting", "Power BI", "SQL" } },
    new Employee { Id = 110, Name = "Pooja",  Age = 30, Salary = 85000, DeptId = 4, Skills = new List<string>{ "Canva", "Photoshop", "Marketing" } }
};

            //Display the names of all employees.
            var names = employees.Select(e => e.Name).ToList();
            Console.WriteLine("Employee Names:");
            names.ForEach(name => Console.WriteLine(name));

            //Display only employee IDs.
            Console.WriteLine("Employee IDs:");
            employees.Select(e => e.Id).ToList().ForEach(id => Console.WriteLine(id));

            //Display Name and Salary.
            var result = employees.Select(e => new
            {
                e.Name,
                e.Salary
            });
            Console.WriteLine("Name and Salary:");
            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name}, Salary: {item.Salary}");
            }

            //Display Name and Age.
            var result2 = employees.Select(e => new
            {
                e.Name,
                e.Age
            });
            Console.WriteLine("Name and Age:");
            foreach (var item in result2)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }

            //Create an anonymous object containing Name and Department Id.
            var result3 = employees.Select(e => new
            {
                e.Name,
                e.DeptId
            });
            Console.WriteLine("Name and Department Id:");
            foreach (var item in result3)
            {
                Console.WriteLine($"Name: {item.Name}, Department Id: {item.DeptId}");
            }
            //Display employees older than 30 years.
            var olderThan30 = employees.Where(e => e.Age > 30).ToList();
            Console.WriteLine("Employees older than 30:");
            olderThan30.ForEach(e => Console.WriteLine($"Name: {e.Name}, Age: {e.Age}"));

            //Display employees whose salary is greater than ₹80,000.
            var highSalaryEmployees = employees.Where(e => e.Salary > 80000).ToList();
            Console.WriteLine("Employees with salary greater than ₹80,000:");
            highSalaryEmployees.ForEach(e => Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}"));

            // Display employees belonging to the IT department.
            var itEmployees = employees.Where(e => e.DeptId == 2).ToList();
            Console.WriteLine("Employees in the IT department:");
            itEmployees.ForEach(e => Console.WriteLine($"Name: {e.Name}, Department Id: {e.DeptId}"));

            //Display employees belonging to the Finance department.
            var financeEmployees = employees.Where(e => e.DeptId == 3).ToList();
            Console.WriteLine("Employees in the Finance department:");
            financeEmployees.ForEach(e => Console.WriteLine($"Name: {e.Name}, Department Id: {e.DeptId}"));

            //Display employees whose name starts with 'A'.

            var employeesStartingWithA = employees.Where(e => e.Name.StartsWith("A")).ToList();
            Console.WriteLine("Employees whose name starts with 'A':");
            employeesStartingWithA.ForEach(e => Console.WriteLine($"Name: {e.Name}, Department Id: {e.DeptId}"));

            //Display employees whose name ends with 'a'.
            var employeesEndingWithA = employees.Where(e => e.Name.EndsWith("a")).ToList();
            Console.WriteLine("Employees whose name ends with 'a':");
            employeesEndingWithA.ForEach(e => Console.WriteLine($"Name: {e.Name}, Department Id: {e.DeptId}"));

            //Display employees whose age is between 25 and 35 years.
            var employeesBetweenAges = employees.Where(e => e.Age >= 25 && e.Age <= 35).ToList();
            Console.WriteLine("Employees whose age is between 25 and 35 years:");
            employeesBetweenAges.ForEach(e => Console.WriteLine($"Name: {e.Name}, Age: {e.Age}"));

            //Display every skill of every employee.
            Console.WriteLine("Every skill of every employee:");
            employees.SelectMany(e => e.Skills).ToList().ForEach(skill => Console.WriteLine(skill));

            //Display all unique skills

            Console.WriteLine("All unique skills:");
            employees.SelectMany(e => e.Skills).Distinct().ToList().ForEach(skill => Console.WriteLine(skill));

            //Display employees who know the "C#" skill.
            var employeesWithCSharpSkill = employees.Where(e => e.Skills.Contains("C#")).ToList();
            Console.WriteLine("Employees who know the 'C#' skill:");
            employeesWithCSharpSkill.ForEach(e => Console.WriteLine($"Name: {e.Name}, Department Id: {e.DeptId}"));

            //Display all distinct Department IDs.
            Console.WriteLine("All distinct Department IDs:");
            employees.Select(e => e.DeptId).Distinct().ToList().ForEach(deptId => Console.WriteLine(deptId));

            //Display all distinct employee ages.
            Console.WriteLine("All distinct employee ages:");
            employees.Select(e => e.Age).Distinct().ToList().ForEach(age => Console.WriteLine(age));

            //Display the first employee.


            Console.WriteLine("First employee:");

            //Display the first three employees.

            //Skip the first employee and display the remaining employees.
            Console.WriteLine("Employees (excluding the first):");
            employees.Skip(1).ToList().ForEach(e => Console.WriteLine($"Name: {e.Name}, Age: {e.Age}"));


            //Skip the first three employees and display the remaining employees.
            Console.WriteLine("Employees (excluding the first three):");
            employees.Skip(3).ToList().ForEach(e => Console.WriteLine($"Name: {e.Name}, Age: {e.Age}"));

            //Find the first employee from the IT department.
            Console.WriteLine("First employee from the IT department:");
            var firstITEmployee = employees.FirstOrDefault(e => e.DeptId == 2);
            if (firstITEmployee != null)
            {
                Console.WriteLine($"Name: {firstITEmployee.Name}, Age: {firstITEmployee.Age}");
            }

            //Find the employee with Id = 999 using FirstOrDefault().
            Console.WriteLine("Employee with Id = 999:");
            var employeeWithId999 = employees.FirstOrDefault(e => e.Id == 999);
            if (employeeWithId999 != null)
            {
                Console.WriteLine($"Name: {employeeWithId999.Name}, Age: {employeeWithId999.Age}");
            }
            else
            {
                Console.WriteLine("No employee found with Id = 999.");
            }

            //Check whether any employee earns more than ₹90,000.
            Console.WriteLine("Employees earning more than ₹90,000:");
            var highEarners = employees.Where(e => e.Salary > 90000).ToList();
            highEarners.ForEach(e => Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}"));


            //Check whether the "Docker" skill exists in the company.
            Console.WriteLine("Checking if 'Docker' skill exists in the company:");
            bool dockerSkillExists = employees.SelectMany(e => e.Skills).Contains("Docker");
            Console.WriteLine($"Docker skill exists: {dockerSkillExists}");


            //Display employee Name and Annual Salary.
            Console.WriteLine("Employee Name and Annual Salary:");
            employees.ToList().ForEach(e => Console.WriteLine($"Name: {e.Name}, Annual Salary: {e.Salary * 12}"));

            //Display employee Name and total number of Skills.
            Console.WriteLine("Employee Name and Total Number of Skills:");
            employees.ToList().ForEach(e => Console.WriteLine($"Name: {e.Name}, Total Skills: {e.Skills.Count}"));

            //Display employees whose salary is between ₹70,000 and ₹90,000.
            Console.WriteLine("Employees whose salary is between ₹70,000 and ₹90,000:");
            employees.Where(e => e.Salary > 70000 && e.Salary < 90000).ToList().ForEach(e => Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}"));

            //Display employees who know the "SQL" skill.'
            Console.WriteLine("Employees who know the 'SQL' skill:");

            //Display employees who belong to the IT department and earn more than ₹80,000.
            Console.WriteLine("Employees who belong to the IT department and earn more than ₹80,000:");
            employees.Where(e => e.DeptId == 2 && e.Salary > 80000).ToList().ForEach(e => Console.WriteLine($"Name: {e.Name}, Salary: {e.Salary}"));

            //Display all skills of employees earning more than ₹80,000.
            Console.WriteLine("All skills of employees earning more than ₹80,000:");


            //Display all skills of employees working in the IT department.
            Console.WriteLine("All skills of employees working in the IT department:");
            employees.Where(e => e.DeptId == 2).SelectMany(e => e.Skills).ToList().ForEach(s => Console.WriteLine($"Skill: {s}"));


        }
    }
}