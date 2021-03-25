using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CompareEMFController : MonoBehaviour
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

    private float ammeterValue;
    // float potentiometerValue;
    [SerializeField]
    private TextMeshProUGUI ammeterReading;
    
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
        //galvanometerValue = galvanometerMinValue + (newSliderPos * .12f * multiplier);
        float galValueWithoutKey = galvanometerMinValue + newSliderPos * .12f;

        float newPotentiometerValue = newSliderPos * multiplier;

        //addedValueDisplay = newSliderPos + additive;
        //float keyValue = addedValueDisplay / 1.45f;
        float newKeyValue = newPotentiometerValue / 1.45f;

        
        Debug.Log("Potentiometer value " + addedValueDisplay);
        
        potentiometerValue = newSliderPos;
        float actualPotentiometerValue = potentiometerValue;

        if (showReadings)
        {
            galvanometerReading.text = galValueWithoutKey.ToString("F2");
            potentiometerReading.text = actualPotentiometerValue.ToString("F2");
        }
        else
        {
            galvanometerReading.text = galValueWithoutKey.ToString("F2");
            //potentiometerReading.text = addedValueDisplay.ToString("F2");
            potentiometerReading.text = newPotentiometerValue.ToString("F2");

        }
    }

    public void MoveRehostatSlider(float newRehostatPos)
    {
        ammeterValue = newRehostatPos;
        ammeterReading.text = newRehostatPos.ToString("F2");
        multiplier = ammeterValue * 1.1f;
    }
    public void AddResistorValue(float resistorvalue)
    {
        //multiplier = resistorvalue;
        additive = resistorvalue;
        //resistorValueHolder.GetComponent<Renderer>().material.color = Color.green;
    }
}
