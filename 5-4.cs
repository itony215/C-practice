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
            int m;
            double score;
            Console.WriteLine("請輸入操作員個數：");            
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入資料數：");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double total = 0;
                Console.WriteLine("操作員" + i + "號：");
                for(int j = 1; j <= m; j++)
                {
                    Console.WriteLine("請輸入第" + j + "筆資料：");
                    score = Convert.ToDouble(Console.ReadLine());
                    total = total + score;
                }
                Console.WriteLine("數據平均為:" + total/m );

            }

            Console.ReadKey();
        }
    }
}
