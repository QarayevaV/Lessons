using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 3: App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
                          alınmalıdır.Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və istifadəçidən generate olunan rəqəmi
                          tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
                          Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir.Sadəcə 2. 3. 4.deyə artır cəhd sayı.İstifadəçi düzgün rəqəmi
                       tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.
            */

            ////Solution 3:
            //int estimate, generatedNum, counter = 0;

            //Console.WriteLine("Texmin oyunu ucun en yuksek reqemi daxil edin: ");
            //int maxNum = int.Parse(Console.ReadLine());
            //Random rand = new Random();
            //generatedNum = rand.Next(1, maxNum);

            //do
            //{
            //    counter++;
            //    Console.WriteLine("{0}. Cehdiniz! Zehmet olmasa reqemi texmin edin: ", counter);
            //    estimate = int.Parse(Console.ReadLine());
            //} while (estimate != generatedNum);

            //Console.WriteLine("{0}. Cehdinizde duzgun reqemi tapdiniz!", counter);

            Console.WriteLine("Texmin oyunu ucun en yuksek deyeri daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int b = rand.Next(1, a);
            Console.WriteLine("Texmin olunan reqemi tapın!");
            int cehd = Convert.ToInt32(Console.ReadLine());
            int countr = 0;
            
            for (; cehd!=b;) //while(cehd != b)
            {
                countr++;
                Console.WriteLine(countr+"."+ "Cehdiniz! Zehmet olmasa reqemi yeniden texmin edin:");
                cehd = Convert.ToInt32(Console.ReadLine());
               
               
            }
            countr++;
            Console.WriteLine(countr + "." + "Cehdinizde düzgün reqemi tapdınız.");
            Console.ReadLine();
            
        }
    }
}
