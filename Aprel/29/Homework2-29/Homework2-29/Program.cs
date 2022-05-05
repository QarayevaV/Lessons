using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_29
{
    class Program
    {
        /* Homework 2:
             Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.

             Məhsul(item) Class'ında olacaq property'lər:
                 Marka
                 Model
                 İstehsal ili
                 Km
                 Yanacaq növü
                 Sürətlər qutusu
                 Alış qiyməti
                 Satış qiyməti
                 Max endirim məbləği
                 Qiymət(private olması mütləqdir!)

            Constructor overload'ları aşağıdakı kimi olmalıdır:
             1. marka, model
             2. marka, model, istehsal ili
             3. marka, model, istehsal ili, km
             4. bütün property'lər

            Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
            satış qiymətini təyin edəcək.Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
            olmalıdır.Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
            Məsələn:
            Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
            satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max.endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
        */
        static void Main(string[] args)
        {
            Class_1 constructor = new Class_1();
            constructor.Marka = "FAW";
            constructor.Model = "Besturn";
            constructor.istehsalİli = "2022";
            constructor.Km = 120;
            constructor.yanacaqNovu = "Dizel";
            constructor.surətlərQutusu = "Avtomat";
            constructor.alısQiymeti = 60800;
            constructor.satısQiymeti = 59000;
            constructor.maxEndirimMeblegi = 1800;
            Console.WriteLine("Marka: " + constructor.Marka);
            Console.WriteLine("Model: " + constructor.Model);
            Console.WriteLine("İstehsal İli: "+constructor.istehsalİli);
            Console.WriteLine("Km: " + constructor.Km);
            Console.WriteLine("Yanacagin novu: " + constructor.yanacaqNovu);
            Console.WriteLine("Suretler Qutusu: " + constructor.surətlərQutusu);
            Console.WriteLine("Satış Qiymeti: " + constructor.satısQiymeti);
            Console.WriteLine("Maksimum endirim meblegi: " + constructor.maxEndirimMeblegi);
            constructor.Constructor("Mercedes", "T-99");
            constructor.Constructor("BMW", "Bestune B3", "2018");
            constructor.Constructor("FAW", "BestuneT99", "2022", 100);
            constructor.CheckoutPrice(65000, 1200, 63800);
            constructor.CheckoutPrice(65000, 1200, 60000);
            Console.ReadLine();
            
        }
    }
}
