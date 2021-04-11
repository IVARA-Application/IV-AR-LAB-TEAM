using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Text sliderValue1;
public Text sliderValue2;
public Text sliderValue3;
private int a;
private int b;
private int c;


    // Update is called once per frame
    void Update()
    {

        a = int.Parse(sliderValue1.text);
        b = int.Parse(sliderValue2.text);
         
        c = (a*b)/(a-b);

        sliderValue3.text = c.ToString();

    }
}
