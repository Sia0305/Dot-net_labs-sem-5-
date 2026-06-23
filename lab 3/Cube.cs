using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Cube
    {
        double side;
        double volume;

        public Cube(double s)
        {
            side = s;
            volume = side * side * side;
        }
        public void DisplayVolume()
        {
            Console.WriteLine("Side of Cube: " + side);
            Console.WriteLine("Volume of Cube: " + volume);
        }
    }
}
