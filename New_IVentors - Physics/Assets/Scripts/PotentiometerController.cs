using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PotentiometerController : MonoBehaviour
{
    private float galvanometerValue;
    [SerializeField]
    private TextMeshProUGUI galvanometerReading;
    private float potentiometerValue;
    [SerializeField]
    private TextMeshProUGUI potentiometerReading;
    
    public float multiplier;
    
    public float additive;
    
    private float galvanometerMinValue = -30f;
    private float addedValueDisplay;

    public static bool showReadings;
    
    // Start is called before the first frame update
    void Start()
    {
        showReadings = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveJockeyWithSlider(float newSliderPos)
    {
        galvanometerValue = galvanometerMinValue + (newSliderPos * .12f * multiplier);
        float galValueWithoutKey = galvanometerMinValue + newSliderPos * .12f;

        addedValueDisplay = newSliderPos + additive;
        float keyValue = addedValueDisplay / 1.3f;
        
        Debug.Log("Potentiometer value " + addedValueDisplay);
        
        potentiometerValue = newSliderPos;

        if (showReadings)
        {
            galvanometerReading.text = galValueWithoutKey.ToString("F2");
            potentiometerReading.text = keyValue.ToString("F2");
        }
        else
        {
            galvanometerReading.text = galValueWithoutKey.ToString("F2");
            potentiometerReading.text = addedValueDisplay.ToString("F2");
        }
    }
    public void AddResistorValue(float resistorvalue)
    {
        //multiplier = resistorvalue;
        additive = resistorvalue;
        //resistorValueHolder.GetComponent<Renderer>().material.color = Color.green;
    }
}
