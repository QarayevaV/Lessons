using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_04._04._22
{
    class Program
    {
        static void Main(string[] args)
        { /*
             Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
                       b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.
             */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Birinci rəqəmi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            object b = a;
            a = (int)b;
            Console.WriteLine("İkinci rəqəmi daxil edin:");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.ReadLine();
        }
    }
}
