using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OhmsSliderController : MonoBehaviour
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

    public Transform destination;
    private float sliderMaxValue;
    public Transform startPoint;
    private float sliderMinValue;
    public Slider slider;

    public float multiplier;

    //public static bool showReadings;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*sliderMaxValue = destination.transform.position.x;
        slider.maxValue = sliderMaxValue;

        sliderMinValue = startPoint.transform.position.x;
        slider.minValue = sliderMinValue;*/
    }

    public void MoveRehostatWithSlider(float newSliderPos)
    {
        sliderMaxValue = destination.transform.position.x;
        slider.maxValue = sliderMaxValue;

        sliderMinValue = startPoint.transform.position.x;
        slider.minValue = sliderMinValue;
        
        rehostatHandle.position = new Vector3(newSliderPos, rehostatHandle.transform.position.y,
            rehostatHandle.transform.position.z);
        //rehostatHandle.position += new Vector3(newSliderPos, 0, 0);
        
        float roundedSliderPos = Mathf.Round(newSliderPos * 100) / 100;
        Debug.Log(roundedSliderPos);
        float posNum = Mathf.Abs(roundedSliderPos);


        ammeterReading = posNum;
        voltmeterReading = posNum * multiplier;
        
        voltmeterValue.text = voltmeterReading.ToString("F2");
        ammeterValue.text = ammeterReading.ToString("F2");
    }
}
