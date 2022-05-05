using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17
{
    class Program
    {
        static void Main(string[] args)
        { //Task in Lesson 1
          /*
              İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

              Menu:
              1 - Element elave et
              2 - Elementleri goster
              3 - Element axtar
              4 - Element editle
              5 - Element sil
              6 - Exit
              Emeliyyat novunu secin:

              Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
              1:
              Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
              Daxil edəndən sonra: "Element elave olundu!"

              2:
              Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
              1. Element = 15
              2. Element = Salam
              3. Element = true
              Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

              3:
              Bunu seçəndə aşağıdakı yazı çıxacaq.
              "Axtarmaq istediyiniz elementi daxil edin: "
              Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
              "Element tapildi : Index :0 - Deyer: Salam"
              tapılmayıbsa bu yazı çıxsın
              "Axtardiginiz element tapilmadi".

              4:
              "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
              ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
              "Axtardiginiz element tapilmadi"
              Varsa:
              "Salam elementini ne ile evezlemek isteyirsiniz?"
              Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

              5:
              İlk öncə bunu soruşsun:
              "Butun elementleri silmek isteyirsiniz? (H/Y)"
              əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
              əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
              ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
              çıxsın.
           */
            Console.WriteLine(" Menu:\n" + " 1 - Element elave et\n" + " 2 - Elementleri goster\n" + " 3 - Element axtar\n" + " 4 - Element editle\n" + " 5 - Element sil\n" + " 6 - Exit\n" + " Emeliyyat novunu secin:");
            int element = Convert.ToInt32(Console.ReadLine());
            ArrayList elements = new ArrayList();
            elements.Add("15");
            elements.Add("Salam");
            elements.Add("true");

            switch (element)
            {
                case 1:
                    Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                    elements.Add(Console.ReadLine());
                    Console.WriteLine("Element elave olundu!");
                    break;
                case 2:
                    for (int i = 0; i < elements.Count; i++)
                    {
                        Console.WriteLine(elements[i]);
                    }
                    Console.WriteLine("Davam etmek ucun Enter'e basin");
                    break;
                case 3:
                    Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
                    object searchElement = Console.ReadLine();
                    if (elements.Contains(searchElement))
                    {
                        int indexOfElement = elements.IndexOf(searchElement);

                        Console.WriteLine("Element tapildi : Index :" + indexOfElement + "- Deyer: " + searchElement);
                    }
                    else
                        Console.WriteLine("Axtardiginiz element tapilmadi.");

                    break;

                case 4:
                    Console.WriteLine("Editlemek istediyiniz elementi daxil edin : ");
                    object editedElement = Console.ReadLine();
                    if (elements.Contains(editedElement))
                    {
                        Console.WriteLine("Editlemek istediyiniz elementi ne ile evezlemek isteyirsiniz?");
                        object editedElement1 = Console.ReadLine();
                        elements.Remove(editedElement);
                        elements.Add(editedElement1);

                        Console.WriteLine("Element editlendi!");
                    }
                    else
                        Console.WriteLine("Axtardiginiz element tapilmadi");

                    break;

                case 5:
                    Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                    char addAnswer = Convert.ToChar(Console.ReadLine());
                    if (addAnswer == 'H')
                    {
                        elements.Clear();
                        Console.WriteLine("Butun elementler silindi");
                    }
                    else
                    {
                        Console.WriteLine("Silmek istediyiniz elementi daxil edin: ");
                        string deletedElement = Console.ReadLine();
                        if (elements.Contains(deletedElement))
                        {
                            elements.Remove(deletedElement);
                            Console.WriteLine("Element silindi");
                        }
                        else
                            Console.WriteLine("Silmek istediyiniz element tapilmadi!");
                    }

                    break;

            }
            Console.ReadLine();

            //Task in Lesson 2
            /*
                Hashtable içinə ENG - AZ olaraq data əlavə ediləcək.

                Soruşulacaq:
                Yeni element əlavə etmək istəyirsiniz? H/Y
                H : Yeni element əlavə etsin
                Y : Bütün elementləri göstərsin

                Qeyd: Əgər user mövcud olan Key əlavə edirsə, bu məlumat sistemdə mövcuddur xətası versin.
             */
            Hashtable ht = new Hashtable();
            ht.Add("Human", "Insan");
            ht.Add("House", "Ev");
            ht.Add("You", "Sen");
            ht.Add("Price", "Qiymet");
            ht.Add("World", "Dunya");
            ht.Add("Car", "Masin");
            ht.Add("Bus", "Avtobus");
          
            Console.WriteLine("Yeni element elave etmek isteyirsiniz? H/Y");

            char addAnswer1 = Convert.ToChar(Console.ReadLine());
            switch (addAnswer1)
            {
                case 'H':
                        Console.WriteLine("Yeni element əlavə edin");
                        ht.Add(Console.ReadLine(), Console.ReadLine());
                        break;
                case 'Y':
                   
                    foreach (DictionaryEntry item in ht)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
                     }
                    
                    break;
            }
            Console.ReadLine();
          

        }
    }
}
