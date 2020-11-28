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
            int year = 0;
            Console.WriteLine("ddddd");
            year = Convert.ToInt32(Console.ReadLine());
            if(year % 400 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}
