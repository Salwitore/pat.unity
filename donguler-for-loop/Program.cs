// See https://aka.ms/new-console-template for more information
using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                if(i%2!=0)
                {
                    Console.Write(i);
                }
            }
            */

            // 1 ile 1000 arasında tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2==0)
                {
                    ciftToplam += i;
                }
                if(i%2!=0)
                {
                    tekToplam += i;
                }
            }
                Console.WriteLine("Çiftlerin toplamı: " + ciftToplam);
                Console.WriteLine("Teklerin toplamı: " + tekToplam);


            // break , continue

             for (int i = 0; i < 10; i++)
             {
                 if (i==4)
                 {
                     break;
                 }
                 Console.WriteLine(i);
             }

            for (int i = 0; i < 10; i++)
             {
                 if (i==4)
                 {
                     continue;
                 }
                 Console.WriteLine(i);
             }


        }
    }
}

