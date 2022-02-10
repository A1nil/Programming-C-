using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Circle
    {
        private double PI { get; set; }
        private double Radius { get; set; }
        private double AreaOfCircle { get; set; }
    }

    public void Circle()
    {
        PI = 3;
        Radius = 2;
    }

    public void GetRadius()
    {
        Console.WriteLine("The value of radius is ");
        Radius = double.Parse(Console.ReadLine());
    }

    public void GetArea()
    {
        Console.Write("");
    }
}
