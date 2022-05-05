using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_24
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4.Bir dənə kiçik console app yazın.Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s.daxil ediləcək. Sonra sinif rəhbərinin adı
                  soruşulacaq.Axırda isə, 10 tələbə adı soruşulacaq.Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                  saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                  Method cəmi 3 parametr qəbul edə bilər. 3 - dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
                    və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın.Tələbə adlarını da collection və ya list
                   şəklində göndərmək haqqınız yoxdur.İp ucu verim dərsdə keçmişdik.
            */
            Console.WriteLine("Sinfin adını daxil edin: ");
            string className = Console.ReadLine();
            Console.WriteLine("Sinif rehberinizin adini daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("1-ci telebenin adini daxil edin: ");
            string student1 = Console.ReadLine();
            Console.WriteLine("2-ci telebenin adini daxil edin: ");
            string student2 = Console.ReadLine();
            Console.WriteLine("3-cu telebenin adini daxil edin: ");
            string student3 = Console.ReadLine();
            Console.WriteLine("4-cu telebenin adini daxil edin: ");
            string student4 = Console.ReadLine();
            Console.WriteLine("5-ci  telebenin adini daxil edin: ");
            string student5 = Console.ReadLine();
            Console.WriteLine("6-ci telebenin adini daxil edin: ");
            string student6 = Console.ReadLine();
            Console.WriteLine("7-ci telebenin adini daxil edin: ");
            string student7 = Console.ReadLine();
            Console.WriteLine("8-ci telebenin adini daxil edin: ");
            string student8 = Console.ReadLine();
            Console.WriteLine("9-cu telebenin adini daxil edin: ");
            string student9 = Console.ReadLine();
            Console.WriteLine("10-cu telebenin adini daxil edin: ");
            string student10 = Console.ReadLine();
            classInformation(className, name, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10);
        }
        public static void classInformation(string a, string b, params string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", a, b, students[i]);
               
            }
            Console.ReadLine();
        }       
    }
}
