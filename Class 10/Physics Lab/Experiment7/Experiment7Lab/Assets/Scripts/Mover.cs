using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    #region Variables
    public float InitialPosValue = 0f;
    public int multiplier = 0;
    public DistanceType unit;
    public bool moveInOppositeDirection =false;

    [SerializeField]
    private UnityEngine.UI.Text textObj;
    [SerializeField]
    public UnityEngine.UI.Slider slider;

    private Vector3 initialPos;
    private Transform objTransform;
    private float calculatedPosValue = 0f;

    #endregion

    #region Properties
    private float LensDislocation
    {
        get { return slider.value; }
    }
    public float CurrentEquipmentPosition
    {
        get { return calculatedPosValue; }
    }

    #endregion

    private void Awake()
    {
        objTransform = gameObject.GetComponent<Transform>();
        initialPos = transform.localPosition;
    }

    public void OnSliderChange()
    {
        objTransform.localPosition = new Vector3(initialPos.x + ((moveInOppositeDirection)? LensDislocation: -LensDislocation), initialPos.y, initialPos.z);
        if(textObj != null)
        {
            calculatedPosValue = InitialPosValue - multiplier * slider.value;
            textObj.text = calculatedPosValue.ToString() + unit.ToString();
        }
    }

}
