using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.name = "Generic computer";
            comp.year = 2022;
            comp.model = "AMD Ryzen";
            Console.WriteLine("Computer name is " + comp.name + ". Introduced in " +comp.year + " and model is " + comp.model + ".");
            Console.ReadLine();
        }
    }
}
