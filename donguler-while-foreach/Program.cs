// See https://aka.ms/new-console-template for more information
using System;

namespace donguler_while_foreach
{

    class Program
    {

         static void Main(string[] args)
        {

            //While
            //1den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdıran program

            Console.WriteLine("Bir sayı gir: ");

            int sayi = Convert.ToInt16(Console.ReadLine());  
            int sayac = 1;
            int toplam = 0;

            while(sayac<=sayi)
            {
                toplam += sayac;    
                sayac++;
            }
            double ortalama = toplam /sayi;

            Console.WriteLine("Ortalama: " + ortalama);


            // a'dan z'ye kadar tüm harfleri konsola yazdır

            char character = 'a';

            while(character <= 'z')
            {              
                Console.Write(character + "|");
                character ++;
            }
                Console.WriteLine();
            //Foreach

            string[] arabalar = {"BMW" , "Toyota" , "Volvo" , "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    } 
}