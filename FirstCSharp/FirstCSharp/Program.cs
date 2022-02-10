using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("In which grade do you study?");
            var study = Console.ReadLine();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your study grade is: {0}", study);

            if(age == "20")
            {
                Console.WriteLine("You are currently studying in Bachelor Degree.");
            }
            if (age == "18")
            {
                Console.WriteLine("You are studying under 12 class");
            }
            Console.ReadLine();

        }
    }
}
