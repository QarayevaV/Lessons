using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 2:
              Əvvəlcədən iki dəyişəndə username və password saxlayın.Bunlar heç bir zaman dəyişməyəcək şəkildə olsun.Yəni proqramda belə dəyişdirmək mümkün olmasın
              Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
              Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
              */
           const string userName = "Teymur";
           const string password = "recebov98";
            int cehd = 0;
            bool blockHesab = false;
            Cehdagain:
            Console.WriteLine("Zehmet olmasa, istifadeçi adını ve parolunu daxil edin:");
            string userName1 = Console.ReadLine();
            string password1 = Console.ReadLine();
            if (!blockHesab)
            {
                if (userName1 != userName || password1 != password)
                {
                    cehd++;
                    Console.WriteLine("Sistemde xeta baş verdi,yeniden sınayın");

                    if (cehd == 3)
                    {
                       
                        Console.WriteLine("Hesab bloklandı");
                        

                    }
                    goto Cehdagain;

                }
                else
                {
                    Console.WriteLine("Sisteme daxil olundu");
                    Console.ReadLine();
                }

            }  
                

            

        }
    }
}
