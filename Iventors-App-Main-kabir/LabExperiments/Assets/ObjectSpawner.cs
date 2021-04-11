using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;
using UnityEngine.XR.ARSubsystems;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToPlace;
    public GameObject placementIndicator;

    private ARRaycastManager arOrigin;
    private Pose placementPose;
    private bool placementPoseIsValid;

    private bool isPlaced;

    private bool placementIndicatorIsActive;
    
    //public Canvas screenCanvas;
    //private AudioSource voiceOver;

    void Start()
    {
        arOrigin = FindObjectOfType<ARRaycastManager>();
        //screenCanvas.enabled = false;
        //voiceOver = GetComponent<AudioSource>();
        placementIndicatorIsActive = true;
    }

    void Update()
    {
         
        UpdatePlacementPose();
        UpdatePlacementIndicator();

        if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!isPlaced)
            {
                PlaceObject();
                placementIndicatorIsActive = false;
                //screenCanvas.enabled = true;
                //voiceOver.Play();
            }
            isPlaced = true;
        }
       
    }

    private void PlaceObject()
    {
        Instantiate(objectToPlace, placementPose.position, objectToPlace.transform.rotation);
    }

    private void UpdatePlacementIndicator()
    {
        if (placementIndicatorIsActive)
        {
            if (placementPoseIsValid)
            {
                placementIndicator.SetActive(true);
                placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
            }
            else
            {
                placementIndicator.SetActive(false);
            }
        }
        
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arOrigin.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }
}