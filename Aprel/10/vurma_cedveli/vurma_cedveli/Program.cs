using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vurma_cedveli
{
    class Program
    {
        static void Main(string[] args)
        {  ////Solution 2:
            //int result = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        result = i * y;
            //        Console.Write("{0}*{1}={2}\t", i, y, result);
            //    }
            //    Console.WriteLine();
            //}
            int d;
            for (int i = 1; i < 10; i++)
            {
                for (int x = 1; x < 10; x++)
                {
                    d = i * x;
                    Console.Write(i + "*" + x + "=" + d+"\t");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
