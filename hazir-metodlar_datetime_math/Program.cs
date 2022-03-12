// See https://aka.ms/new-console-template for more information
using System;

namespace hazir_metodlar_datetime_math
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Bilgisayardaki günün tarihi
            Console.WriteLine(DateTime.Now.Date); //Saati ignore eder 00.00 olarak çıkar
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın gününü string olarak döner
            Console.WriteLine(DateTime.Now.DayOfYear); //içinde bulunduğu yılın kaçıncı günündeyim

            Console.WriteLine(DateTime.Now.ToLongDateString()); //Günün ismi, Ay XX, 20XX 
            Console.WriteLine(DateTime.Now.ToShortDateString()); //Gün/Ay/Yıl
            Console.WriteLine(DateTime.Now.ToLongTimeString()); //Saat:Dakika:Saniye
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //Saat:Dakika

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//11
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Per
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Perşembe

            Console.WriteLine(DateTime.Now.ToString("MM"));//03
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Mar
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Mart

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-2)); //Mutlak alır
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); //İçine yazılan double değerden büyük en küçük tam sayıyı döndürür |23
            Console.WriteLine(Math.Round(22.3)); //Yuvarlama |22
            Console.WriteLine(Math.Round(22.7)); //|23
            Console.WriteLine(Math.Floor(22.20)); //İçine yazılan double değerden küçük en büyük tam sayıyı döndürür ||22

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(3,4));//üs alma
            Console.WriteLine(Math.Sqrt(9));//kare kök alır
            Console.WriteLine(Math.Log(9));// e tabanında logaritmik karşılığını getirir
            Console.WriteLine(Math.Exp(3));// e üzeri karşılığı
            Console.WriteLine(Math.Log10(10)); // 10 tabanında logaritmik karşılığı

            

        }
    }
}
