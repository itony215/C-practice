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
            int n =0;
            int max=0;
            int total=0;
            int i = 0;
            double avg = 0;
            while (n >= 0)
            {
                Console.WriteLine("請輸入數字(-1結束)：");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
                total = total + n;
                i++;
            }
            i = i - 1;
            total = total + 1;
            if (i == 0)
            {
                Console.ReadKey();
            }
            else
            {
                avg = (total / i);
                Console.WriteLine("==============");
                Console.WriteLine("最大數字:" + max);
                Console.WriteLine("總次數:" + i);
                Console.WriteLine("總和:" + total);
                Console.WriteLine("平均:" + avg);
                Console.ReadKey();
            }
            
        }
    }
}