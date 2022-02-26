// See https://aka.ms/new-console-template for more information
using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main (string[]args)
        {
            //Array Sort
            int[] sayiDizisi = {23,12,4,86,43,58,92,100};


            Console.WriteLine("********** Sırasız Dizi *********");

            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+"|");
            }
            Console.WriteLine();
            Array.Sort(sayiDizisi); // Küçükten büyüğe sıralar.

            Console.WriteLine("********* Sıralı Dizi ***********");

             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+"|");
            }
            Console.WriteLine();
            //Array Clear
            Console.WriteLine("*********** Clear ************");
            Array.Clear(sayiDizisi,2,2); // sayiDizisi elemanlarını kullanarak 2. indeksten itibaren 2 tane elemanı sıfırladık.
            
             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+"|");
            }
            Console.WriteLine();
            //Array Reverse
            Console.WriteLine("********** Reverse ***********");
            Array.Reverse(sayiDizisi); //Diziyi aynalar
            
             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+"|");
            }
            Console.WriteLine();
            //Array IndexOf 
            Console.WriteLine("********* IndexOf ***********");
            Console.WriteLine(Array.IndexOf(sayiDizisi,86)); // Dizinin içindeki sayının indexini döndürür

            //Array Resize
            Console.WriteLine("********* Resize **********");
            Array.Resize<int>(ref sayiDizisi , 12);
             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+"|");
            }


        }
    }
}
