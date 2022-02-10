using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandO
{
    class Rectangle
    {
        public double length;
        public double breadth;
        public double Area;
        public double Perimeter;

        public void GetData()
        {
            Console.WriteLine("Enter the length");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = double.Parse(Console.ReadLine());
        }

        public void CalculateArea()
        {
            Area = length * breadth;
        }

        public void CalculatePerimeter()
        {
            Perimeter = 2 * (length * breadth);
        }

        public void DisplayArea()
        {
            Console.WriteLine("The area is " + Area + ".");
        }

        public void DisplayPerimeter()
        {
            Console.WriteLine("The perimeter is " + Perimeter + ".");
        }
    }
}
