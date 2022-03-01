// See https://aka.ms/new-console-template for more information
using System;
    namespace metotlar_overloading
    {
        class Program
        {
            static void Main(string[] args)
            {
                // out parametreler
                string sayi = "999";

                bool sonuc = int.TryParse(sayi,out int outSayi);

                if(sonuc)
                {
                    Console.WriteLine("Başarılı!");
                    Console.WriteLine(outSayi);
                }
                else
                {
                    Console.WriteLine("Başarısız!");
                }

                Metotlar metotlar = new Metotlar();
                int sayi1 = 4;
                int sayi2 = 5;

                metotlar.Topla(sayi1,sayi2,out int toplamSonuc);
                Console.WriteLine(toplamSonuc);


                //Metot Aşırı Yükleme - Overloading
                int ifade = 999;
                string stringİfade = "999";
                metotlar.EkranaYazdir(ifade);
                metotlar.EkranaYazdir(stringİfade);
                metotlar.EkranaYazdir("Harun","Üst");
                // Metot imzası
                // metotadı + parametreSayisi + parametre
            }
        }
        class Metotlar
        {
            public void Topla(int a , int b ,out int toplam)
            {
                toplam = a+b;
            }
            public void EkranaYazdir(string deger)
            {
                Console.WriteLine(deger);
            }
            public void EkranaYazdir(int deger)
            {
                Console.WriteLine(deger);
            }
            public void EkranaYazdir(string deger1,string deger2)
            {
                Console.WriteLine(deger1+deger2);
            }
        }
    }

