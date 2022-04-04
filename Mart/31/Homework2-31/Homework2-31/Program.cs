using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 2:
             Bir dənə anket proqramı yığacaqsınız.İstifadəçidən onun haqqında məlumatları toplayacaqsınız.Bu məlumatlar ad, soyad, cins, doğum tarixi,
           yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq.Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.
             İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
             Ad: Mark
             Soyad: Henry
             Cins: K və ya Q
             Doğum tarixi: 1990 - 10 - 10
             Yaşadığı ölkə: Azərbaycan
             Yaşadığı şəhər: Bakı
             Boy: 1.75
             Çəki: 26.50
             Maaş: 2500.00
             */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Adınızı daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı daxil edin: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Cinsinizi K və ya Q kimi daxil edin: ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Doğum tarixinizi daxil edin: ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Yaşadığınız ölkəni daxil edin: ");
            string country = Console.ReadLine();
            Console.WriteLine("Yaşadığınız şəhəri daxil edin: ");
            string city = Console.ReadLine();
            Console.WriteLine("Boyunuzu daxil edin: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çəkinizi daxil edin: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Maaşınızı daxil edin: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("Soyad: " + surname);
            Console.WriteLine("Cins: " + gender);
            Console.WriteLine("Tarix: " + birthDate);
            Console.WriteLine("Ölkə: " + country);
            Console.WriteLine("Şəhər: " + city);
            Console.WriteLine("Boy: " + height);
            Console.WriteLine("Çəki: " + weight);
            Console.WriteLine("Maaş: " + salary);

            Console.ReadLine();





        } 
    }
}
