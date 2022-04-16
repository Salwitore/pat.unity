using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KoleksiyonYapilari : MonoBehaviour
{
    [SerializeField] int[] ornekdizi;
    [SerializeField] List<int> ornekdizi2;
    
    void Start()
    {
        

    }
    private void Arraydizi()
    {
        int[] numbers = new int[4];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;

        foreach (var number in numbers)
        {
            Debug.Log(number);
        }

    }
    private void Listdizi()
    {
        /*List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);*/
        List<int> numbers = new List<int>()//kısa yazım
        {
            1,2,3,4
        };

        foreach (var number in numbers)
        {
            Debug.Log(number);
        }
    }
    private void Dictionarydizi()
    {
        Dictionary<string, string> ornekler = new Dictionary<string, string>();
        //key         value
        ornekler.Add("Bilgisayar", "Computer"); //bir key birden fazla value alamaz
        ornekler.Add("Ev", "Home");

        Debug.Log(ornekler["Bilgisayar"]);
        string value = ornekler.FirstOrDefault(x => x.Key == "Ev").Value;
        Debug.Log(value);

        foreach (var v in ornekler)
        {
            Debug.Log(v);
        }


    }
    private void Queuedizi()
    {
        Queue<string> days = new Queue<string>();

        days.Enqueue("Pazartesi");
        days.Enqueue("Salı");
        days.Enqueue("Çarşamba");

        for (int i = 1; i <= 3; i++)
        {
            Debug.Log(days.Dequeue()); //dizi elemanını kullandıktan sonra diziden çıkarır

        }

    }
}
