using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_24
{
        class Student
    {
        //public void StudentInfo(string name, string surname)
        //{
        //    Console.WriteLine("Student Informations: {0} {1}", name, surname);
        //}
        //private void StudentMobile(string number)
        //{
        //    Console.WriteLine("Mobile number: {0} ", number);
        //}

        public int CalcAverage(int num1, int num2, int num3)
        {
            int result = 0;
            result = (num1 + num2 + num3) / 3;
            return result;
        }

        public void RateAverage(int num1, int num2, int num3)
        {
            int result = CalcAverage(num1, num2, num3);

            if (result >= 45)
                Console.WriteLine("Tebrikler,siz kecdiniz!");
            else
                Console.WriteLine("Kesildiniz!");
            Console.ReadLine();
        }

        public void RateAverage(string num1, string num2, string num3)
        {
            RateAverage(Convert.ToInt32(num1), Convert.ToInt32(num2), Convert.ToInt32(num3));
        }

        public void RateAverage(double num1, string num2, string num3)
        {
            RateAverage(Convert.ToInt32(num1), Convert.ToInt32(num2), Convert.ToInt32(num3));
        }
        public void RateAverage(int num1, double num2, decimal num3)
        {
            RateAverage(Convert.ToInt32(num1), Convert.ToInt32(num2), Convert.ToInt32(num3));
        }
        public void RateAverage(decimal num1, string num2, int num3)
        {
            RateAverage(Convert.ToInt32(num1), Convert.ToInt32(num2), Convert.ToInt32(num3));
        }
        public void RateAverage(int num1, string num2, float num3)
        {
            RateAverage(Convert.ToInt32(num1), Convert.ToInt32(num2), Convert.ToInt32(num3));
        }
    }
    }

