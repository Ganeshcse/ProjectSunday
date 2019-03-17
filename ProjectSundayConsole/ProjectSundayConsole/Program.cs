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
            Console.Read();
            Console.WriteLine("Hallo, I have been modified after first checkin!");
            int x = 20;
            object obj = x;
            Console.WriteLine(obj.ToString());
        }
    }
}
