﻿// See https://aka.ms/new-console-template for more information
using System;
namespace if_else_if {
    class Program {
        static void Main(string [] args) {

            int time = DateTime.Now.Hour;


            if(time >=6 && time < 11) {
                Console.WriteLine("Günaydın!");
            }
            else if(time<=18) {
                Console.WriteLine("İyi günler!");
            }
            else {
                Console.WriteLine("İyi Geceler!");
            }

            string sonuc = time<=18 ? "İyi günler!" : "İyi geceler!";

            sonuc = time>=6 && time <11 ? "Günaydın" : time <=18 ? "İyi günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc);


        }
    }
}