using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 23564542;
            //Yeni yaratdığımız int y dəyişəninin qüvvədə olma sahəsi blok (skop) daxilində olduğundan blokdan kənarda ona müraciət etmək olmur.Elə bil ki, bu fiqurlu mötərizə '{' int x kodunun qırılma nöqtəsidir,yəni int x kodu daxilində y dəyişəni mövcud deyil, yeni açılmış skop daxilində mövcuddur.
            {
                int y;
                // Amma bu blok (skop) daxilində int x dəyişəninə müraciət edə bilərik,səbəbi ondan ibarətdir ki, int y int x-in bloku içərisindədir. Ona görə int x int y-ə görə qlobaldı, blokdan kənar isə lokal dəyişən hesab olunur.
                y = x;
                Console.WriteLine(y);
                Console.ReadLine();
            }
        }
    }
}
