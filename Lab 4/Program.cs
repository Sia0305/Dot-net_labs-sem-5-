using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter the name of the doctor:");
            // string name = Console.ReadLine();

            //Console.WriteLine("Enter the basic salary of the doctor:");
            //double basicSalary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the doctor allowance:");
            //double doctorAllowance = Convert.ToDouble(Console.ReadLine());

            //Doctor d = new Doctor(name, basicSalary, doctorAllowance);
            //d.Display();

            //Console.WriteLine("Enter the name of the patient:");
            //string patientName = Console.ReadLine();

            //Console.WriteLine("Enter the base charge for the patient:");
            //double baseCharge = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Is the patient an inpatient or outpatient? (i/o):");
            //string patientType = Console.ReadLine();

            //Billing billing = new Billing();
            //billing.PatientName = patientName;


            IInventoryManager grocery = new GroceryStock();
            IInventoryManager electronic = new ElectronicStock();

            try
            {
                grocery.AddStock("Rice", 20);
                grocery.SellStock("Rice", 30);

                electronic.AddStock("Laptop", 10);
                electronic.SellStock("Laptop", 70); // Stock shortage
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
