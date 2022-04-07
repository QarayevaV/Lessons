using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 3: İstifadəçidən 10 dəyəri alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. Çıxmad və toplama əməliyyatlarında 10-cu dəyər daxil
                        edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Birinci dəyəri daxil edin:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci dəyəri daxil edin:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü dəyəri daxil edin:");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dördüncü dəyəri daxil edin:");
            int a4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Beşinci dəyəri daxil edin:");
            int a5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altıncı dəyəri daxil edin:");
            int a6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeddinci dəyəri daxil edin:");
            int a7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Səkkizinci dəyəri daxil edin:");
            int a8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doqquzuncu dəyəri daxil edin:");
            int a9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Onuncu dəyəri daxil edin:");
            int a10 = Convert.ToInt32(Console.ReadLine());
            int b = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10;
            int b1 = b + 1;
            decimal c = (decimal)a1 - a2 - a3 - a4 - a5 - a6 - a7 - a8 - a9 - a10;
            decimal c1=c-1;
            int d = a1 * a2 * a3 * a4 * a5 * a6 * a7 * a8 * a9 * a10;
            int d1 = d * 20;
            float f = (float)a1 / a2 / a3 / a4 / a5 / a6 / a7 / a8 / a9 / a10;
            float f1 = f / 20;
         
            Console.ReadLine();
        }
    }
}
