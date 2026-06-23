using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Employee
    {
        int id;
        string name;
        string department;
        string Designation;
        double salary;

        public void GetEmpDetails()
        {
            Console.Write("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Employee department:");
            department = Console.ReadLine();

            Console.Write("Enter Employee Designation:");
            Designation = Console.ReadLine();

            Console.Write("Enter Employee Salary:");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpDetails()
        {
            Console.WriteLine("\nEmployee Details");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
