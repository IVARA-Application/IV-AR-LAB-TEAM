using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject visual;
    private bool settleInPosition = false;

    private void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;
        visual.SetActive(false);
    }
    private void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        if(hits.Count > 0)
        {
            if (!settleInPosition)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;
            }
            if (!visual.activeInHierarchy)
            {
                visual.SetActive(true);
            }
        }

        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            settleInPosition = true;
        }

    }

    public void resetMovingPointer()
    {
        settleInPosition = false;
    }
}
