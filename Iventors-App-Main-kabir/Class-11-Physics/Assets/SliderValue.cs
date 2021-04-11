using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
   public Text sliderValue;
   public Text mainValue;
   public Slider slider;
   public double M;
   private double a;
   void Update()
 {
 
 sliderValue.text = slider.value.ToString("0.0");
 a = double.Parse(sliderValue.text);
M = a + 0.1;
mainValue.text = M.ToString("0.0");

 }
}
