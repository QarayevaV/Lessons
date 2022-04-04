using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_31
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 3:
             İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız. Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
             edəcəksiniz. Daha sonra int dəyişənini byte tipinə cast edəcəksiniz (explicit conversion).
             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
             tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.
             */
             checked
            { 
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Yaşınızı daxil edin: ");
            byte age = Convert.ToByte(Console.ReadLine());
            int takeByteToIntConvert = Convert.ToInt32(age);
            byte a = (byte)takeByteToIntConvert;


            Console.WriteLine("Maaşınızı daxil edin: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            int takeDoubleToIntConvert = Convert.ToInt32(salary);
            byte a1 = (byte)takeDoubleToIntConvert;

                unchecked
                {
                    Console.WriteLine("Boyunuzu daxil edin: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    int takeDoubleValToIntConvert = Convert.ToInt32(height);
                    byte a2 = (byte)takeDoubleValToIntConvert;


                    Console.WriteLine("Çəkinizi daxil edin: ");
                    decimal weight = Convert.ToDecimal(Console.ReadLine());
                    int takeDecimalToIntConvert = Convert.ToInt32(weight);
                    byte a3 = (byte)takeDecimalToIntConvert;
                }
            }
        }
    }
}
