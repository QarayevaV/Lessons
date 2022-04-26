using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    class Program
    {
        static void Main(string[] args)
        { /*
             Homework 1:
             Kiçik bir kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə edə biləcəyi əməliyyatları nömrələriylə göstərin.
             "Etmek istediyiniz emeliyyati secin:"
             "1. Toplama"
             "2. Çıxma"
             "3. Vurma"
             "4. Bölmə"
             İstifadəçi əməliyyatı seçəndən sonra a və b dəyərlərini rəqəm olaraq alın və əməliyyatı icra edib nəticəni göstərin.
             Sadəcə bir dənə bölmə əməliyyatında əgər b-nin dəyəri 1-dən kiçik olarsa ekrana "böləcəyiniz dəyər müsbət dəyər olmalıdır"
             yazdırın.
          */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            testagain:
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bölmə");
            int operation = Convert.ToInt32(Console.ReadLine());
        
            if (operation <1 || operation > 4)
            {
                Console.WriteLine("Səhv əməliyyat seçmisiniz!");
                goto testagain;
                }
                Console.WriteLine("iki ədəd daxil edin:");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c;
            if (operation == 1)
                {
                c = a + b;
                Console.WriteLine("Nəticə:"+ c);
            }
           else if (operation == 2)
            {
                c = a - b;
                Console.WriteLine("Nəticə:" + c);
            }
            else if (operation == 3)
            {
                c = a * b;
                Console.WriteLine("Nəticə:" + c);
            }
            
            else 
            { if (b < 1)
                {
                    Console.WriteLine("b-nin dəyəri 1-dən böyük olmalıdır");
                   
                }
                else if (operation == 4)
                {
                    c = a / b;
                    Console.WriteLine("Nəticə:" + c);

                }

                }

            Console.ReadLine();
        }
    }
}
