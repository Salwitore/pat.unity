// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
namespace Koleksiyonlar
{
    class Program
    {
        public static void Main(String[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> Object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(7);
            sayiListesi.Add(9);
            sayiListesi.Add(54);
            sayiListesi.Add(25);
            sayiListesi.Add(2);
            sayiListesi.Add(12);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Mavi");
            renkListesi.Add("Mor");

            //Count

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);


            foreach (var sayi in sayiListesi)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            foreach (var renk in renkListesi)
            {
                Console.Write(renk + " ");
            }
            Console.Write("\n------------------------------");
            //Foreach ve listForeach ile elemanlar erişim
            Console.WriteLine();
            sayiListesi.ForEach(sayi => Console.Write(sayi + " ")); //Listelerde foreachin kısa bir kullanımı
            Console.WriteLine();
            renkListesi.ForEach(renk => Console.Write(renk + " "));

            //Listeden eleman çıkarma

            //Verilen değeri çıkarmak için Remove()
            sayiListesi.Remove(54);
            renkListesi.Remove("Yeşil");
            //Verilen indexi çıkarmak için RemoveAt()
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(4);

            Console.Write("\n------------------------------");
            Console.WriteLine();
            sayiListesi.ForEach(sayi => Console.Write(sayi + " "));
            Console.WriteLine();
            renkListesi.ForEach(renk => Console.Write(renk + " "));

            //Liste içerisinde arama
            //Contains()

            Console.WriteLine("\n------------------------------");
            if (sayiListesi.Contains(25))
            {
                Console.WriteLine("25 lise içinde bulundu!");
            }

            //Eleman ile indexe erişme
            //BinarySearch()
            sayiListesi.Sort();
            renkListesi.Sort();
            Console.WriteLine(sayiListesi.BinarySearch(25));        //Bu metodun düzgün çalışması için listenin sıralanmış olması gerekir
            Console.WriteLine(renkListesi.BinarySearch("Sari"));    //Listeye ilk eklendiği indexi döndürür

            //Diziyi Liste çevirme

            string[] hayvanArray = { "Kedi", "Köpek", "Aslan" };

            List<string> hayvanList = new List<string>(hayvanArray);

            hayvanList.ForEach(hayvan => Console.Write(hayvan + " "));
            Console.WriteLine();

            //Listeyi nasıl temizleriz?
            hayvanList.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcılarList = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar("Harun", "Üst", 21);
            Kullanıcılar kullanıcı2 = new Kullanıcılar("Çağatay", "Üresin", 29);

            kullanıcılarList.Add(kullanıcı1);
            kullanıcılarList.Add(kullanıcı2);

            kullanıcılarList.info_kullanici_list();

        }
    }
    class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public Kullanıcılar(string isim, string soyisim, int yas)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
    static class Extensions
    {
        public static void info_kullanici_list(this List<Kullanıcılar> kullaniciList)
        {
            foreach (var kullanici in kullaniciList)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("İsim:    " + kullanici.Isim);
                Console.WriteLine("Soyisim: " + kullanici.Soyisim);
                Console.WriteLine("Yaş:     " + kullanici.Yas);
                Console.WriteLine("--------------------------");
            }
        }
    }
}

