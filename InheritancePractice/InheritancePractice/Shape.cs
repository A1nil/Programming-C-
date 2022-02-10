using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Shape
    {
        protected double length;
        protected double breadth;
        protected double radius;
        protected double area;
        protected double perimeter;

        public void GetLength()
        {
            Console.WriteLine("The value of length is ");
            length = double.Parse(Console.ReadLine());
        }

        public void GetBreadth()
        {
            Console.WriteLine("The value of breadth is ");
            breadth = double.Parse(Console.ReadLine());
        }

        public void GetRadius()
        {
            Console.WriteLine("The value of radius is ");
            length = double.Parse(Console.ReadLine());
        }
    }
}
