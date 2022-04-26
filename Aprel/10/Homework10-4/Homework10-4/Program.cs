using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin");
            string varVal = Console.ReadLine();
            int a = int.Parse(varVal);
            while(a!=0)
            {
                Console.WriteLine(a);
                a = a - 1;
            }

            Console.ReadLine();
        }
    }
}
