using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ParentClass
    {
        private int a;
        protected int b;
        public int c;

        public void GetA()
        {
            Console.WriteLine("The value of a is ");
            a = int.Parse(Console.ReadLine());
        }

        public void GetB()
        {
            Console.WriteLine("The value of b is ");
            b = int.Parse(Console.ReadLine());
        }

        public void GetC()
        {
            Console.WriteLine("The value of c is ");
            c = int.Parse(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine("a={0} b={1} c={2} ",a,b,c);
        }
    }
}
