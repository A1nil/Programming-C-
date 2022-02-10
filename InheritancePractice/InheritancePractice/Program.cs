using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            R.GetLength();
            R.GetBreadth();
            R.DisplayArea();
            Console.ReadLine();
        }
    }
}
