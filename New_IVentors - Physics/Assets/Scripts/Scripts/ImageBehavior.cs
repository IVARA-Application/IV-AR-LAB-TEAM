using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageBehavior : MonoBehaviour
{
    public GameObject imageIndicator;
    public Mover CandleMover;
    public Lens lensProperties;
    public Mover Screen;
    public UnityEngine.UI.Image formedImage;
    private Transform objTransform;
    private float Scalefactor;
    private float ImageFormedLocation = 0f;

    private void Awake()
    {
        objTransform = gameObject.GetComponent<Transform>();
    }

    private void Start()
    {
        CandleMover.OnSliderChange();
        Screen.OnSliderChange();
        OnSliderChange();
    }
    public void OnSliderChange()
    {
        {
            ImageFormedLocation = CandleMover.CurrentEquipmentPosition * lensProperties.FocalLength / (CandleMover.CurrentEquipmentPosition - lensProperties.FocalLength);
            imageIndicator.transform.position = new Vector3(ImageFormedLocation/100f, imageIndicator.transform.position.y, imageIndicator.transform.position.z);
            Scalefactor = ImageFormedLocation/Screen.CurrentEquipmentPosition;

            if(Scalefactor > 0.05f || Scalefactor < -0.05f)
            objTransform.localScale = new Vector3(Scalefactor,Scalefactor,Scalefactor);

            if (Scalefactor < 1f && Scalefactor > 0)
                formedImage.color = new Color(1,1,1,Scalefactor);
            else if(Scalefactor > 0f)
                formedImage.color = new Color(1, 1, 1,2 - Scalefactor);
            else
                formedImage.color = new Color(1, 1, 1, 0);
        }

    }

}
