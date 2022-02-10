using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandO
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            R.GetData();
            R.CalculateArea();
            R.CalculatePerimeter();
            R.DisplayArea();
            R.DisplayPerimeter();
            Console.ReadLine();
        }
    }
}
