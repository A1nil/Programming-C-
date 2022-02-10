using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Rectangle:Shape
    {
        public void GetArea()
        {
            area = length * breadth;
        }

        public void GetPerimeter()
        {
            perimeter = 2 * (length * breadth);
        }

        public void DisplayArea()
        {
            Console.WriteLine("The area of rectangle is ");
        }
    }
}
