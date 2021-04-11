using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Text sliderValue;
    public Text sliderValue1;
    
public Text sliderValue2;

private float a;
private float b;
private float c;
 public Slider slider;
 public Slider slidera;
 
 
 void Update()
 {
 
 sliderValue.text = slider.value.ToString();
 sliderValue1.text = slidera.value.ToString();

  a = float.Parse(sliderValue.text);
  b = float.Parse(sliderValue1.text);
  c = (a*b)/(a-b);
 sliderValue2.text = c.ToString("0.0");






 
 }
}
