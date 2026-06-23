using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Car
    {
        string Make;
        string model;
        int year;
        string FuelType;
        double Horsepower;

        public Car(string make, string model, int year, string fuelType, double horsepower)
        {
            this.Make = make;
            this.model = model;
            this.year = year;
            this.FuelType = fuelType;
            this.Horsepower = horsepower;
        }
        public void DisplayCarDetail()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Horsepower: {Horsepower}");
        }
    }
}
