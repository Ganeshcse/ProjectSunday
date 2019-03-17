using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSundayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Entered value is " + name);

            Console.ReadLine();
        }
    }
}
