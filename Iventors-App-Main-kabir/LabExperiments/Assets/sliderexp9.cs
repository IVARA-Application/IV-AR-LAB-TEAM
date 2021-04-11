using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderexp9 : MonoBehaviour
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
  d = (b*c)/(a-b);
 mainValue.text = d.ToString("0.0");






 
 }
}
