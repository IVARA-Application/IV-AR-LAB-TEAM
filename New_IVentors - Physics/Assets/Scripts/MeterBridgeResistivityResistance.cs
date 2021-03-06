﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MeterBridgeResistivityResistance : MonoBehaviour
{
    [SerializeField]
    private Transform jockey;
    
    private float galvanometerValue;
    [SerializeField]
    private TextMeshProUGUI galvanometerReading;
    private float meterBridgeValue;
    [SerializeField]
    private TextMeshProUGUI meterBridgeReading;

    /*public Transform destination;
    private float sliderMaxValue;
    public Transform startPoint;
    private float sliderMinValue;
    public Slider slider;*/
    public float multiplier;
    
    private float galvanometerMinValue = -20f;

    public static bool showReadings;

    public GameObject resistorValueHolder;
    
    // Start is called before the first frame update
    void Start()
    {
        showReadings = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*sliderMaxValue = destination.transform.position.x;
        slider.maxValue = sliderMaxValue;

        sliderMinValue = startPoint.transform.position.x;
        slider.minValue = sliderMinValue;*/
    }

    public void MoveJockeyWithSlider(float newSliderPos)
    {
        /*sliderMaxValue = destination.transform.position.x;
        slider.maxValue = sliderMaxValue;

        sliderMinValue = startPoint.transform.position.x;
        slider.minValue = sliderMinValue;*/
        
        
        /*jockey.position = new Vector3(newSliderPos, jockey.transform.position.y,
            jockey.transform.position.z);*/

        galvanometerValue = galvanometerMinValue + (newSliderPos * .4f * multiplier);
        float galValueWithoutKey = galvanometerMinValue + newSliderPos * .4f;
        /*float roundedSliderPos = Mathf.Round(newSliderPos * 100) / 100;
        Debug.Log(roundedSliderPos);
        float posNum = Mathf.Abs(roundedSliderPos);*/

        meterBridgeValue = newSliderPos;

        if (showReadings)
        {
            galvanometerReading.text = galvanometerValue.ToString("F2");
            meterBridgeReading.text = meterBridgeValue.ToString("F2");
        }
        else
        {
            galvanometerReading.text = galValueWithoutKey.ToString("F2");
            meterBridgeReading.text = meterBridgeValue.ToString("F2");
        }
        
    }

    public void AddResistorValue(float resistorvalue)
    {
        multiplier = resistorvalue;
        resistorValueHolder.GetComponent<Renderer>().material.color = Color.green;
    }
}
