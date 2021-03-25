using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefractionPrismController : MonoBehaviour
{
    private float refractionPrismValue;
    [SerializeField]
    private TextMeshProUGUI incidentValueText;
    //private int emergentValue;
    [SerializeField]
    private TextMeshProUGUI deviationValueText;
    
    [SerializeField]
    private TextMeshProUGUI refractionValueText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderDrag(float newRefractionValue)
    {
        refractionPrismValue = newRefractionValue;
        //refraction angle starts...
        float refraction = Mathf.Sin((refractionPrismValue * Mathf.PI) / 270f);
        //Debug.Log("refarc " + refraction);
        float refractedAngle = Mathf.Rad2Deg * Mathf.Asin(refraction);
        refractionValueText.text = $"{refractedAngle}";
        //Refraction angle ends...
        
        //Deviation starts...
        float deviation = 2 * refractionPrismValue - 60;
        deviationValueText.text = $"{deviation}";

        //Deviation ends...

        incidentValueText.text = $"{refractionPrismValue}";
    }
}
