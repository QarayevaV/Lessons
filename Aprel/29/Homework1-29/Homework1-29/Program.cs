﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_29
{ /*
             Homework 1:
             İnternetdə Access Modifiers mövzusunu araşdırın və elə edin ki, CheckCustomerFromDb methodunu nə public nədə private istifadə etmədən,
             Program class'ında istifadə edə bilim. Inherit almaq şansınız yoxdur, yanlız aşağıdakı kimi yazanda işləməlidir və dəyişikliyi Customer
             class'ı tərəfdə etməlisiniz.

             Nümunə:
             Customer customer = new Customer();
             customer.CheckCustomerFromDb();

           */
    public class Customer
    {
        void CheckCustomerFromDb(string name, string surname)
        {   Console.WriteLine("Name: "+name+" Surname: "+surname);
            Console.ReadLine();
        }
          class Program
          {
              static void Main(string[] args)
              {
                Customer customer = new Customer();
                customer.CheckCustomerFromDb("Terlan","Quliyev");
              }
          }
    }
}
    
