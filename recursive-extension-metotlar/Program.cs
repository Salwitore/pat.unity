// See https://aka.ms/new-console-template for more information
using System;
namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz Yinelemeli
            //3^4
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result *=3;
            }
            Console.WriteLine(result);
            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3,4));
            
            //Extensions Metotlar
            string ifade = "Harun üst";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());
            }
            int[] dizi = {10,2,5,3,9,4,80,29,40};
            dizi.ArraySirala();
            foreach (var num in dizi)
            {
                Console.Write(num+"|");
            }
            Console.WriteLine();
            int sayi = 48;
            if(sayi.ciftMi())
            {
                Console.WriteLine(sayi+" Sayisi Çift");
            }
            else
            {
                Console.WriteLine(sayi+" Sayisi Tek");
            }
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if(üs<2)
            {
                return sayi;
            }

            return Expo(sayi,üs-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3)*3
        //Expo(3,2)*3*3
        //Expo(3,1)*3*3*3
        //3*3*3*3
        
    }
    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] ArraySirala(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if(array[j]>array[i])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static bool ciftMi(this int param)
        {
            if(param %2 == 0)
            {
                return true;
            }
            else{
                return false;
            }
        }
        public static string GetFirstCharacter(this string param)
        {

            return param.Substring(0,1);

        }
    }
}
