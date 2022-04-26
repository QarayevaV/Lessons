using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 3:
             Switch -case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
             və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
             istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
             */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            RepeatStart:
            Console.WriteLine("Etmek istədiyiniz əməliyyatı seçin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bölmə");
            int operation =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İki ədəd daxil edin:");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c;
            
            switch (operation)
            {
                case 1:
                    
                        c = a + b;
                        Console.WriteLine("1. Toplama" + "=" + c);
                    goto RepeatStart;

                case 2:
                    c = a - b;
                    Console.WriteLine("1. Çıxma" + "=" + c);
                    goto RepeatStart;
                case 3:

                    c = a * b;
                    Console.WriteLine("1. Vurma" + "=" + c);
                    goto RepeatStart;

                case 4:
                    c = a / b;
                    Console.WriteLine("1. Bölmə" + "=" + c);
                    goto RepeatStart;

                default:
                    Console.WriteLine("Səhv əməliyyat daxil etmisiniz!");
                    goto RepeatStart;
            }
            
           
            



            
        }
    }
}
