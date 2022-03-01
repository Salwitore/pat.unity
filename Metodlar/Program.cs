// See https://aka.ms/new-console-template for more information
using System;
namespace Metodlar
{
    class Program
    {
        static int topla(int a,int b)
        {
            return a+b;
        }
        static void Main(string[] args)
        {
            //erisim_belirteci geri_dönüş_tipi metot_adı(parametreListesi/argüman)
            //{
                ////Komutlar;
            //}

            int a = 3;
            int b = 4;

            Console.WriteLine(topla(a,b));
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(ornek.ArttirVeTopla(ref a,ref b)));
            ornek.EkranaYazdir(Convert.ToString(topla(a,b)));
            

        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }
}

