// See https://aka.ms/new-console-template for more information

using System;


namespace Operatorler {

    class Program {

        static void Main(string[]args) {

            // Atama ve işlemli atama
            Console.WriteLine("****Atama ve işlemli atama****");
            int x = 4;
            int y = 5;


            Console.WriteLine(y);
            y = y+4;
            Console.WriteLine(y);
            y += 4;
            Console.WriteLine(y);
            y /= 3;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal Operatörler


            Console.WriteLine("****Mantıksal Operatorler****");
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted) {

                Console.WriteLine("Perfect!");

            }
            if(isSuccess || isCompleted) {

                Console.WriteLine("Great!");

            }
            if(isSuccess && !isCompleted) {

                Console.WriteLine("Fine!");

            }
            
            // İlişkisel Operatörler
            // < , > , <= , >= , == , !=

            Console.WriteLine("****İlişkisel Operatorler****");

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);

            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a >=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);


            Console.WriteLine("****Aritmetik Operatorler****");

            // / , * , + , - 

            int sayi = 10;

            int sayi2 = 5;

            int sonuc1 = sayi / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi * sayi2;
            Console.WriteLine(sonuc1);

            // % mod almak için

            sonuc1 = sayi%sayi2;
            Console.WriteLine(sonuc1);

        }

    }




}
