// See https://aka.ms/new-console-template for more information
using System;

namespace algoritma_odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı
              girmesini isteyin(n). Sonrasında kullanıcıdan n adet
              pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu
              sayılardan çift olanlar console'a yazdırın.         
            */


            Console.WriteLine("Bir sayı giriniz: ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(n+" Adet sayı giriniz: ");
            
            int[] array1 = new int[n];


            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt16(Console.ReadLine());
                array1[i] = num;
            }
            Console.Write("Çift olan sayılar: ");
            foreach (var num in array1)
            {
                if(num %2 == 0)
                {
                    Console.Write(num+" ");
                }
            }

            /*2. Bir konsul uygulamasında kullanıcıdan pozitif iki sayı
              girmesini isyetin (n,m). Sonrasında kullanıcıdan n adet
              sayı girmesini isteyin.Kullanıcının girmiş olduğu 
              sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            */

            Console.WriteLine("İlk sayıyı girin.");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin.");
            int m = Convert.ToInt16(Console.ReadLine());
            int[] array2 = new int[n1];
            Console.WriteLine(n1+" Adet sayı giriniz: ");
            for (int i = 0; i < n1; i++)
            {
                int num = Convert.ToInt16(Console.ReadLine());
                array2[i] = num;
            }

            Console.WriteLine(m+" sayısına tam bölünen sayılar;");
            foreach (var num in array2)
            {
                if(num%m==0)
                {   
                    Console.Write(num+" ");
                }
            }
            

            /*3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı
            girmesini isteyin(n). Sonrasında kullanıcıdan n adet kelime
            girmesini isteyin. Kullanıcının girişini yaptığı kelimeleri
            sondan başa doğru console'a yazdırın. 
            
            */

            Console.WriteLine("Yazıcağınız kelime sayısını giriniz;");    
            int n2 = Convert.ToInt16(Console.ReadLine());
            string[] array3 = new string[n2];
            Console.WriteLine(n2+" adet kelimeyi giriniz: ");

            for (int i = 0; i < n2; i++)
            {
                array3[i] = Console.ReadLine();
            }

            for (int i = n2-1; i >= 0; i--)
            {
                Console.Write(array3[i]+" ");
            }

            /*4. Bir konsol uygulamasında kullanıcıdan bir cümle 
            yazmaını isteyin.Cümledeki toplam kelime ve harf sayısını
            console'a yazdırın.
            */

            Console.WriteLine("Bir cümle yazınız: ");
            string n3 = Console.ReadLine();
            
            string[] array4 = n3.Split(" ");
            int w = 0;
            int wl = 0;
            foreach (var item in array4)
            {
              w++;
            }
            Console.WriteLine("Kelime sayısı: " + w);

            for (int i = 0; i < w; i++)
            {
                string temp1 = array4[i];
                
                for (int j = 0; j < temp1.Length; j++)
                {    
                    wl++;        
                }

            }
            Console.WriteLine("Harf sayısı: " + wl);
        }
    }
}
