using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefractionGlassSliderController : MonoBehaviour
{
    private float refractionValue;
    [SerializeField]
    private TextMeshProUGUI incidentValueText;
    //private int emergentValue;
    [SerializeField]
    private TextMeshProUGUI emergentValueText;

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
        refractionValue = newRefractionValue;

        incidentValueText.text = $"{refractionValue}";
        emergentValueText.text = $"{refractionValue}";

    }
}
