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
            int n = 0;
            int bonus = 0;
            int total = 0;
            int left = 0;
            Console.WriteLine("請輸入可樂瓶數：");
            n = Convert.ToInt32(Console.ReadLine());
            total = n;
            while (n > 6)
            {
                left = n % 7;
                n = n / 7;
                bonus += n;
                n = n + left;
                Console.WriteLine("left:" + left);
                Console.WriteLine("bonus:" + bonus);
                Console.WriteLine("n:" + n);
            } 
            Console.WriteLine("total:" + (total+bonus));
            Console.ReadKey();
        }

    }
}
