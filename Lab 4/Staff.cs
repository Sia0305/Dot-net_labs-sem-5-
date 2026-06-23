using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class staff
    {
        protected string Name;
        protected double BasicSalary;
        public double DoctorAllowance;
        public staff(string name, double basicSalary, double doctorAllowance)
        {
            Name = name;
            BasicSalary = basicSalary;
            DoctorAllowance = doctorAllowance;
        }

        public staff(string name, double basicSalary)
        {
            Name = name;
            BasicSalary = basicSalary;
        }

        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
        }
    }
    class Doctor : staff
    {

        public Doctor(string name, double basicSalary, double doctorAllowance) : base(name, basicSalary)
        {
            DoctorAllowance = doctorAllowance;
        }
        public override double CalculateSalary()
        {
            return BasicSalary + DoctorAllowance;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Doctor Allowance: " + DoctorAllowance);
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }
}
