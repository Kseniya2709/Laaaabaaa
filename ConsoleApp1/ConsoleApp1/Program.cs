using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first name: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string last = Console.ReadLine();
            Console.WriteLine("Hello, "+first+" "+last);
            Console.ReadLine();
        }
    }
}
