using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_04._04._22
{
    class Program
    {
        static void Main(string[] args)
        { 
             /*
             Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu
                         çıxma, vurma və bölmə üçün də edin.
             */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Birinci rəqəmi daxil edin:");
            decimal a1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("İkinci rəqəmi daxil edin:");
            decimal a2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Üçüncü rəqəmi daxil edin:");
            decimal a3 = Convert.ToDecimal(Console.ReadLine());
            decimal b = a1 + a2 + a3;
            decimal c = a1 - a2 - a3;
            decimal d = a1 * a2 * a3;
            decimal f = a1 / a2 / a3;
            Console.WriteLine("Nəticə:" + a1 + "+" + a2 + "+" + a3 + "=" + b);
            Console.WriteLine("Nəticə:" + a1 + "-" + a2 + "-" + a3 + "=" + c);
            Console.WriteLine("Nəticə:" + a1 + "*" + a2 + "*" + a3 + "=" + d);
            Console.WriteLine("Nəticə:" + a1 + "/" + a2 + "/" + a3 + "=" + f);
            Console.ReadLine();
        }
    }
}
