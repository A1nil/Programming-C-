using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fact = 1, i;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factor -  {0}", fact);
            Console.ReadLine();
        }
    }
}
