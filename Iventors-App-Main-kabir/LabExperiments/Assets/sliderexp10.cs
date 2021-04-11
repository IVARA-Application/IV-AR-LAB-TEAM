using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderexp10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text mainValue;
    public Text sliderValue1;
    
public Text sliderValue2;
public Text sliderValue3;

private float a;
private float b;
private float c;
private float d;
private float e;
 public Slider slider;
 public Slider slidera;
 public Slider sliderb;
 
 
 void Update()
 {
 
 sliderValue1.text = slider.value.ToString("0.0");
 sliderValue2.text = slidera.value.ToString("0.0");
 sliderValue3.text = sliderb.value.ToString("0.0");

  a = float.Parse(sliderValue1.text);
  b = float.Parse(sliderValue2.text);
  c = float.Parse(sliderValue3.text);
  d = (a*(c/b))/2;
  

 mainValue.text = d.ToString("0.0");






 
 }
}

