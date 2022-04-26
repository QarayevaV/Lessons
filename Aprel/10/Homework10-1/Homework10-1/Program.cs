using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1: İstifadəçi mənfi dəyər daxil edənə qədər, daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın.
             */
            ////Solution 1:
            //Console.WriteLine("Toplamaq istediyiniz reqemleri daxil edin: ");
            //Console.WriteLine("Qeyd: Neticeni gormek ucun menfi eded daxil edin.");

            //decimal sum = 0;

            //while (true)
            //{
            //    string uInput = Console.ReadLine();
            //    decimal value = decimal.Parse(uInput);

            //    if (value < 0)
            //        break;
            //    else
            //        sum = sum + value;
            //        //sum += value;
            //}

            //Console.WriteLine("Toplam: {0}", sum);
            bool stopLoop = false;
            int c = 0;
            while (!stopLoop)
            {
                Console.WriteLine("Her hansısa bir eded daxil edin");
                int a = Convert.ToInt32(Console.ReadLine());
                     if (a >= 0)
                {
                    Console.WriteLine(c);
                    c = c + a;
                    Console.Write(c);
                    Console.ReadLine();

                }
                else 
                {
                    Console.WriteLine("Menfi deyer daxil etmisiniz.Hesablama sonlandi!");
                    Console.ReadLine();
                    break;
                }

                
            }



        }
    }
}
