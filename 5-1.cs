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
            int a;
            int d;
            int n;
            int total = 0;
            Console.WriteLine("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N: ");
            n = Convert.ToInt32(Console.ReadLine());
            string varString;
            for (int i=0; i<n; i++)
            {
                total = a + i * d + total;
                varString = Convert.ToString(i+1);
                Console.WriteLine((i+1)+"\t" + total);
            }
            Console.ReadKey();
        }
    }
}