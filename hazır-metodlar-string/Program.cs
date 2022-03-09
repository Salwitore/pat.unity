// See https://aka.ms/new-console-template for more information
using System;

namespace hazır_metodlar_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hoşgeldiniz!";
            string degisken2 = "CSharp";


            //Lenght;
            Console.WriteLine(degisken.Length);

            //Toupper , Tolower;
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat 
            Console.WriteLine(String.Concat(degisken," Merhaba!"));

            //CompareTo 
            //Birinci degisken ikinci degiskene eşitse 0 döndürür,
            //Birinci degisken ikinci degiskenden daha fazla karakter sayısına sahipse 1 döndürür,
            //Birinci degisken ikinci degiskenden daha az karakter sayısına sahipse -1 döndürür.

            Console.WriteLine(degisken.CompareTo(degisken2));

            //Compare
            //String kütüphanesinden çağrılır CompareTo'dan farkı fazladan bir parametre daha alır ve true yada false olma durumuna göre;
            //true derser büyük küçük harf duyarsız hale gelir
            //false derkes büyük küçük harf duyarlı hale gelir

            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            //degisken1in içinde degisken 2 varmı
            Console.WriteLine(degisken.Contains(degisken2));

            //EndsWith
            //Sonu o parametreyle bitiyormu
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));

            //StartWith
            //Başlıyormu

            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            //degiskenin içinde parametreyi arar bulursa parametrenin ilk karakterinin indexini döndürür,Bulamazsa -1 döndürür
            Console.WriteLine(degisken.IndexOf("CSharp"));

            //LastIndexOf
            //Degiskenin içinde paramterteri sondan başlayarak arar
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            //degiskenin istediğimiz indeksine karakter eklememizi sağlar
            Console.WriteLine(degisken.Insert(0,"Merhaba !"));

            //Padleft , PadRight
            //Degiskenin sağına yada soluna degiskenin toplam indeks sayısını baz alarak boşluk ekler
            //Örneğin Harun kelimesinin sağına 2 boşluk eklemek istersem parametreye 7 yazmak gerekir
            //Eğer boşluk yerine başka bir karakter eklemek istersek ikinci parametreye eklemek istediğimiz karakter yazılır

            Console.WriteLine(degisken+degisken2.PadLeft(8));
            Console.WriteLine(degisken+degisken2.PadLeft(8,'*'));
            Console.WriteLine(degisken.PadRight(30)+degisken2);
            Console.WriteLine(degisken.PadRight(30,'*')+degisken2);

            //Remove
            //Verdiğimiz indeksden başlayarak sona kadar siler
            //ikinci indeks değerini verirsen o indekse kadar siler

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace 
            //ilk parametreyi bulup siler onun yerine ikinci parametreyi ekler

            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            //Verdiğimiz ilk parametreye verilen karaktere göre ayırarak bir dizi oluşturur 
            //Verdiğimiz ikinci parametreye ise oluşan dizinin döndürmek istediğimiz elemanın indeksini yazarız

            Console.WriteLine(degisken.Split(' ')[1]);
            string[] degisken3 = degisken.Split(' '); //Burdada oluşturulan diziyi kendi oluşturduğumuz diziye aktardık.
            Console.WriteLine(degisken3[1]);
            //SubString
            //sadece tek parametre girersek o indeksten başlayıp sonuna kadarki kısmı döndürür
            //ikinci parametreyide girersek ikinci parametredeki indekse kadar döndürür

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,20));


        }
    }
}
