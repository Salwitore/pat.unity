// See https://aka.ms/new-console-template for more information
using System;

namespace console_programlama
{

    class Program
    {

        public static void Main (string[] args)
        {

        Console.WriteLine("İsminizi Girin");
        string name = Console.ReadLine();
        Console.WriteLine("Soyisminizi Girin");
        string surname = Console.ReadLine();

        Console.WriteLine("Hoşgeldin" + name + " " + surname);


       }
    }
}        