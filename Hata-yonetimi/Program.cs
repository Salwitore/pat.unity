// See https://aka.ms/new-console-template for more information
using System;


namespace Hata_yonetimi {


    class Program {

        static void Main(string[] args) {


            /*
            try // Kodu denediğim kısım
            {
                Console.WriteLine("Lütfen bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı: " + sayi);
            }
            catch (System.Exception ex) //Kodda hata varsa çalışıcak blok
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());               
            }
            finally //Kodda hata olsada olmasada çalışıcak blok (Optional)
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            */

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("2000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz.");

                Console.WriteLine(ex);


            }

        }
    }
}
