using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ParallelConnectionController : MonoBehaviour
{
    [SerializeField]
    private Transform rehostatHandle;

    private float rehostatPos;

    private float voltmeterReading;
    [SerializeField]
    private TextMeshProUGUI voltmeterValue;
    private float ammeterReading;
    [SerializeField]
    private TextMeshProUGUI ammeterValue;

    public static bool showReadings;

    public float parallelResistorValue;
    
    public Transform destination;
    private float sliderMaxValue;
    public Transform startPoint;
    private float sliderMinValue;
    public Slider slider;

    
    // Start is called before the first frame update
    void Start()
    {
        showReadings = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveRehostatWithSlider(float newSliderPos)
    {
        sliderMaxValue = destination.transform.position.z;
        slider.maxValue = sliderMaxValue;

        sliderMinValue = startPoint.transform.position.z;
        slider.minValue = sliderMinValue;
        
        rehostatHandle.position = new Vector3(
            rehostatHandle.transform.position.x, rehostatHandle.transform.position.y, newSliderPos);
        
        float roundedSliderPos = Mathf.Round(newSliderPos * 1000) / 1000;
        Debug.Log(roundedSliderPos);
        float posNum = Mathf.Abs(roundedSliderPos);


        ammeterReading = posNum;
        //8 is the total value of the two resistors 10 ohms + 40 ohms in parallel and the 5 is an equivalent figure of the
        //scale for ammeter and voltmeter readings.
        //voltmeterReading = newSliderPos * 5 * 8;
        //Using V = IR
        voltmeterReading = ammeterReading * parallelResistorValue;


        if (showReadings)
        {
            voltmeterValue.text = voltmeterReading.ToString("F3") + "V";
            ammeterValue.text = ammeterReading.ToString("F3") + "A";
        }
    }
}
