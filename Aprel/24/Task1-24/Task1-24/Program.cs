using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_24
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in lesson 1:
            /* Bir dənə class içində 2 fərqli method yaradacaqsız.Biri public digəri private olacaq şəkildə edib public method'u program class'ında çağıracaqsız.
             Method ekrana hər hansısa bir şey yazdırsın kifayətdir.
            */

            //Student student = new Student();
            // student.StudentInfo("Aysel", "Memmedova");
            #endregion

            #region Homework 1:
            /* Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
            Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq.CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
            Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
            tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək.Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq.
            */
            Student student = new Student();
            Console.WriteLine("Add name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Add surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Add price1: ");
            int price1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add price2: ");
            int price2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Add price3: ");
            int price3 = int.Parse(Console.ReadLine());
            studentInfo(name, surname, price1, price2, price3);
            student.RateAverage(price1.ToString(), price2.ToString(), price3.ToString());
            //student.RateAverage(10.5, "20", "30");
            //student.RateAverage(10, 10.5, 10.5M);
            //student.RateAverage(10.5M, "50", 60);
            //student.RateAverage(60, "50", 70.5F);




        }
        static void studentInfo(string a, string b, int c1, int c2, int c3)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1} {2} {3} {4}", a, b, c1, c2, c3);
           
             Console.ReadLine();
        }
       
        #endregion
    }
}
    
