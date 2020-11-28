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
            int a = 0;
            int b = 0;
            int c = 0;
            int score;
            Console.WriteLine("請輸入學生個數：");            
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("請輸入第"+i+"學生成績：");
                score = Convert.ToInt32(Console.ReadLine());
                if(score>=80)
                {
                    a = a + 1;
                }
                else if(score>=60)
                {
                    b = b + 1;
                }
                else
                {
                    c = c + 1;
                }
            }
            Console.WriteLine("A："+a);
            Console.WriteLine("B：" + b);
            Console.WriteLine("C：" + c);
            Console.ReadKey();
        }
    }
}
