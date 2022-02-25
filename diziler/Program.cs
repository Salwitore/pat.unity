// See https://aka.ms/new-console-template for more information
using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama

            string[] renkler = new string[4];
            string[] hayvanlar = {"kedi" , "köpek" , "maymun"};
            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim

            renkler[0] = "mavi";
            dizi[2] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[2]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            // kullanıcıdan dizinin boyutunu ve dizinin elemanlarını alıp ortalamasını hesaplayan program

            Console.WriteLine("Dizinin boyutunu giriniz: ");
            int boyut = Convert.ToInt16(Console.ReadLine());
            int[] dizi1 = new int [boyut];
            int toplam = 0;
            Console.WriteLine("Dizinin elemanlarını giriniz");
            for (int i = 0; i < boyut  ;i++)
            {
                Console.WriteLine((i+1)+". Eleman: ");
                dizi1[i] = Convert.ToInt16(Console.ReadLine());
            }    
            foreach (var Eleman in dizi1)
            {
                toplam += Eleman;
            }
            toplam = toplam / dizi1.Length;
            Console.WriteLine("Dizinin ortalaması: " + toplam);
        }
    }
}
