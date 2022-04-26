using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 1:
             İki dənə array yaradacaqsız və user'dən tələbənin ad və yaş məlumatlarını alıb bu array'lərdə saxlayacaqsız. Array'ların ölçüsü eyni
             olacaq və onu da user'dən soruşacaqsız. Sonra döngüdə istifadəçidən ad və yaş məlumatlarını ayrı-ayrılıqda soruşub array'lərə
             dolduracaqsız.Sonra başqa bir for döngüsündə tələbənin ad və yaş məlumatlarını index'lə birlikdə ekrana yazdıracaqsız.
            (0.Orkah 27 yaşındadır.)
            */
            //Console.WriteLine("Sinifde nece telebe var?");
            //byte studentCount = Convert.ToByte(Console.ReadLine());

            //string[] studentsName = new string[studentCount];
            //byte[] studentsAge = new byte[studentCount];


            //for (int i = 0; i < studentsName.Length; i++)


            //{
            //    Console.WriteLine(i + ". Telebenin adini daxil edin: ");
            //    studentsName[i] = Console.ReadLine();
            //}
            //for (int j = 0; j < studentsAge.Length; j++)
            //{

            //    Console.WriteLine(j + ". Telebenin yaşını daxil edin: ");
            //    studentsAge[j] = Convert.ToByte(Console.ReadLine());
            //}

            //for (int i = 0; i < studentsAge.Length; i++)
            //{
            //    Console.WriteLine(i + "." + studentsName[i] + " " + studentsAge[i] + " yasindadir");
            //}



            //Console.ReadLine();



            //Homework 2:
            // Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.Bunun üçün öncə bütün elementlərin toplamını
            // tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
            // bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
            // Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın.Bunu həm for döngüsüylə edin həm də foreach.
            //int count = 0;

            //int[] numberArr = new int[]
            //{
            //    5,
            //    4,
            //    78,
            //    56,
            //    100,
            //    32,

            //};
            //for (int i = 0; i < numberArr.Length; i++)

            //{
            //    count = count + numberArr[i];
            //}
            //Console.WriteLine(count / numberArr.Length);
            //Console.ReadLine();
            //decimal count = 0;
            //Console.WriteLine("Array nece elementli olsun? ");
            //short numCount = Convert.ToInt16(Console.ReadLine());
            //decimal[] numberArray = new decimal[numCount];
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    Console.WriteLine(i + ". Ededleri daxil edin: ");

            //    numberArray[i] = Convert.ToDecimal(Console.ReadLine());
            //    count = count + numberArray[i];

            //}
            //Console.WriteLine(count);
            //Console.WriteLine(count / numCount);

            //Console.ReadLine();


            /*Homework 3:
             int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 }; bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın.
             Ancaq bunu edərkən sort və reverse method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.
             */

            int[] numArr = new int[11]
            {
                20,
                92,
                100,
                55,
                98,
                1,
                18,
                26,
                75,
                33,
                12
            };

            int varElement;
             for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = i + 1; j < numArr.Length; j++)
                {
                    if (numArr[i] > numArr[j])
                    {
                        varElement = numArr[i];
                        numArr[i] = numArr[j];
                        numArr[j] = varElement;
                    }
                }
                Console.WriteLine(numArr[i]);
            }
            
            Console.ReadLine();
            
            /* Homework 4:
             Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
             toplamını ekrana yazdırın. (Max və Min method'larından istifadə etmək olmaz)
            */

            //int[] randNums = new int[100];
            //Random rand = new Random();

            //int min = 100000;
            //int max = 0;
            //int sum = 0;

            //for (int i = 0; i < randNums.Length; i++)
            //{
            //    randNums[i] = rand.Next(1, 100000);

            //    if (randNums[i] > max)
            //        max = randNums[i];

            //    if (randNums[i] < min)
            //        min = randNums[i];

            //    sum += randNums[i];
            //}

            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);
            //Console.WriteLine("Sum: " + sum);






            //decimal generatedNUm, count = 0;
            //decimal[] random = new decimal[100];


            //for (int i = 0; i < 100; i++)
            //{
            //    Random random1 = new Random();
            //    generatedNUm = random1.Next(1, 10000);

            //    random[i] = generatedNUm;

            //    count += random[i];

            //}
            //Console.WriteLine(count);
            //Console.ReadLine();



            // Homework 5:
            // Array'ın property və method'larını araşdırın, nə işə yarayır, necə istifadə edilir, nə üçün istifadə edilir və s.
            // Araşdırdığınız method və property'ləri mütləq praktika edin!



        }
    }
}