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
            int n;
            Console.WriteLine("n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int m;
            Console.WriteLine("m: ");
            m = Convert.ToInt32(Console.ReadLine());
            int total = 1;
            int total2 = 1;
            int total3 = 1;
            for (int i=n; i>1; i--)
            {
                total = total * i;
                Console.WriteLine(i+"\t"+total);
            }

            for (int i = n-m; i > 1; i--)
            {
                total2 = total2 * i;
                Console.WriteLine(i + "\t" + total2);
            }

            for (int i = m; i > 1; i--)
            {
                total3 = total3 * i;
                Console.WriteLine(i + "\t" + total3);
            }
            Console.WriteLine(total/(total2*total3));
            Console.ReadKey();
        }
    }
}