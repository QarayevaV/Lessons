using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_29
{
    class Class_1
    {
        public string Marka;
        public string Model;
        public string istehsalİli;
        public int Km;
        public string yanacaqNovu;
        public string surətlərQutusu;
        public int alısQiymeti;
        public int satısQiymeti;
        public int maxEndirimMeblegi;
        private int Qiymet;
        public void Constructor(string marka, string model)
        {
            marka = Marka;
            model = Model;
        }
        public void Constructor(string marka, string model, string IstehsalIli)
        {
            marka = Marka;
            model = Model;
            IstehsalIli = istehsalİli;
        }
        public void Constructor(string marka, string model, string IstehsalIli, int km)
        {
            marka = Marka;
            model = Model;
            IstehsalIli = istehsalİli;
            km = Km;
        }
       
        public void CheckoutPrice(int a, int b, int result)
        {
            Console.WriteLine("Satis Qiymeti: " + a + ", "+ "MaxEndirim: " + b + ", "+ "Qiymet: " + result);
            Qiymet = a - b;
            if(result == Qiymet)
            Console.WriteLine("Teyin edilen qiymet: " + Qiymet);
            else
            Console.WriteLine("Max.endirim qiymetinden asagı bir qiymet teyin etmeye calisdiniz!");
           
        }
       
    }

}
    


