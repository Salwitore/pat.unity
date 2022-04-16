using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegerTipveRefTipFark : MonoBehaviour
{
    
    void Start()
    {
        //Referans tipler
        // string tipinde bir values1 değişkeni oluşturduk.Bunun ram kaynak adresi ram201 olsun.
        string[] values1 = { "Istanbul", "Ankara", "Izmir" };
        // string tipinde bir values2 değişkeni oluşturduk.Bunun ram kaynak adresi ram202 olsun.
        string[] values2 = { "Adana", "Bursa", "Diyarbakir" };

        values2 = values1;//Burada değerini değil direkt ram kaynak adresini atamış oluruz.

        values1[0] = "Bodrum";

        Debug.Log(values1[0]);//Bodrum
        Debug.Log(values2[0]);//Bodrum
        values2[1] = "Sivas";
        Debug.Log(values2[1]);//Sivas
        Debug.Log(values1[1]);//Sivas
        //Ram kaynak adresleri eşitlendiğinden birinin üstünde değişiklik yaptığımızda diğerininde değişmiş olur.
    }
    private void Degertipler()
    {
        //Değer tip

        int sayi1 = 10; //Stack alanda int tipinde sayi1 değişkeni oluşturuyor.Ram kaynak adresi:ram101 olsun.
        int sayi2 = sayi1;/*Int tipinde sayi2 değişkeni oluşturduk.Ram kaynak adresi:ram102 olsun.ram kaynak adresine
                          10 değerini atadık.*/

        sayi1++;

        Debug.Log("Sayı1 =>" + sayi1);//Sayı1 =>11
        Debug.Log("Sayı2 =>" + sayi2);//Sayı2 =>10 Ram kaynak adresleri farklı olduğu için sayı2 değişmez.

    }
    
}
