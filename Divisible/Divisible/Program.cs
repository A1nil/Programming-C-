using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter number");
            a = int.Parse(Console.ReadLine());

            for(a = 1; a <= 200; a++)
            {
                if(a % 7== 0 || a % 13 == 0 || a % 14 == 0)
                {
                    Console.WriteLine("The divisible number are: {0}", a);
                }
            }
            Console.ReadLine();
        }
    }
}
