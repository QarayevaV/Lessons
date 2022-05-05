using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_24
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3.Local function'lar yaradaraq bir kalkulyator yaradın.
                Ümumi bir calculate methodu olmalıdır və onun içində Toplama, Çıxma, Vurma və Bölmə methodları olacaq.
                Overloadı biraz araşdırın ki, burada toplama çıxma və s. hamısı iki decimal, iki int, iki string parametr ilə işləməlidir.
                Əlavə olaraqda user string-decimal, decimal-int və int-string parametrlərini daxil etsə də işləməlidir.
                Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, (15, 15), (15.2M, 20.5M) qaydada istifadə ediləcək.
                Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq("15", 20.2M) yada int-string üçün(20, "15") belə.
                Bölmə zamanı divide zero exeption'dan qaçının.
                Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
                Yəni 100 - ün 5 faizi neçədir? hesablayacaq.İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10(a parametri),
                100 - ün(b parametrinin) neçə faizidir?
                Bu faiz hesablama methodları da yuxarıdakı digər methodlar kimi iki decimal, iki int, iki string və əlavə olaraq string-decimal,
                decimal-int və int-string parametrləri ilə işləyəcək.
            */
            Console.WriteLine("Birinci ededi daxil edin: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin: ");
            int num2 = int.Parse(Console.ReadLine());
            Calculate(num1, num2);
        }
        static void Calculate(decimal a, decimal b)
        {

            decimal Addition(decimal num1, decimal num2)
            {
                decimal result = num1 + num2;
                return result;
            }
           
            decimal Subtraction(decimal num1, decimal num2)
            {
                decimal result = num1 - num2;
                return result;
            }
            decimal Multiplication(decimal num1, decimal num2)
            {
                decimal result = num1 * num2;
                return result;
            }
            decimal Divide(decimal num1, decimal num2)
            {
                if (num2 == 0)
                    return 0;

                decimal result = num1 / num2;
                return result;
            }
            decimal Percent(decimal num1, decimal num2)
            {
                decimal result = (num1 * num2) / 100;
                return result;
            }
            decimal Percent1(decimal num1, decimal num2)
            {
                decimal result = (num1 / num2) * 100;
                return result;
            }

            Console.WriteLine(Addition(a, b));
            Console.WriteLine(Subtraction(a, b));
            Console.WriteLine(Multiplication(a, b));
            Console.WriteLine(Divide(a, b));
            Console.WriteLine(Percent(a, b));
            Console.WriteLine(Percent1(a, b));
            Console.ReadLine();
        }
    }
}
    

