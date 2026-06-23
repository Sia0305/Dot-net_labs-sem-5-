using System;
using System.Management.Instrumentation;
using System.Xml.Linq;

namespace lab_3
{
    internal class Program
    {
        static void Main()
        {
            //p1
            //Faculty faculty = new Faculty();

            //faculty.GetFacultyDetails();
            //faculty.DisplayFacultyDetails();

            //p2
            //Employee[] emp = new Employee[2];
            //for(int i= 0; i < emp.Length;i++)
            //{
            //    emp[i] = new Employee();
            //    Console.WriteLine("\n Employee" + (i + 1));
            //    emp[i].GetEmpDetails();
            //}
            //Console.WriteLine("\nEmployee Details");

            //for(int i= 0;i<2;i++)
            //{
            //    emp[i].DisplayEmpDetails();
            //}

            //p3
            //Console.WriteLine("Enter side of the cube:");
            //double side = Convert.ToDouble(Console.ReadLine());

            //Cube c = new Cube(side);
            //c.DisplayVolume();

            //Console.ReadKey();

            //p4
            Console.Write("Enter Car Make: ");
           string Make = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Car Model: ");
           string Model = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Car Year:");
           int  Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Car FuelType:");
           string FuelType = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Car Horsepower:");
            double Horsepower = Convert.ToDouble(Console.ReadLine());

            Car c = new Car(Make,Model,Year,FuelType,Horsepower);
            c.DisplayCarDetail();
        }

    }
}

