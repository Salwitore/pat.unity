using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParamsKeyWord : MonoBehaviour
{
    [SerializeField] Text text;
    
    void Start()
    {
        Method(1, 1, 1, 1, 1, 1);

    }

    void Method(params int[] x){ //params keywordu methoda istediğimiz kadar parametre almamızı sağlar.

        int sonuc = 0;

        foreach(var num in x)
        {
            sonuc += num;
        }
        text.text = sonuc.ToString();

    }
    
}
