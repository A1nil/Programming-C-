using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.GetA();
            c.GetB();
            c.GetC();
            c.PrintData();
            Console.ReadLine();
        }
    }
}
