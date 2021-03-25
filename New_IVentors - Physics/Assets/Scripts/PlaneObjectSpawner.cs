using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;
using UnityEngine.XR.ARSubsystems;

public class PlaneObjectSpawner : MonoBehaviour
{
    public GameObject objectToPlace;
    public GameObject placementIndicator;
    public GameObject verticalObject;

    public ARPlaneManager planeManager;

    private ARRaycastManager arOrigin;
    private Pose placementPose;
    private bool placementPoseIsValid;

    private bool isVerticalPlaced;
    private bool ishorizontalPlaced;

    public GameObject verticalARSession;
    public GameObject horizontalARSession;


    //public Canvas screenCanvas;
    //private AudioSource voiceOver;

    void Start()
    {
        arOrigin = FindObjectOfType<ARRaycastManager>();
        //screenCanvas.enabled = false;
        //voiceOver = GetComponent<AudioSource>();
    }

    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();

        if (PlaneDetectionMode.Vertical != 0)
        {
            if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (!isVerticalPlaced)
                {
                    PlaceVerticalObject();
                }
                isVerticalPlaced = true;
                verticalARSession.SetActive(false);
                horizontalARSession.SetActive(true);
            }
        }
        if (PlaneDetectionMode.Horizontal != 0)
        {
            if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (!ishorizontalPlaced)
                {
                    PlaceHorizontalObject();
                }
                ishorizontalPlaced = true;
                /*horizontalARSession.SetActive(false);
                verticalARSession.SetActive(true);*/
            }
        }
        /*if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!isPlaced)
            {
                PlaceObject();
                //screenCanvas.enabled = true;
                //voiceOver.Play();
            }
            isPlaced = true;
        }*/
    }

    private void PlaceHorizontalObject()
    {
        Instantiate(objectToPlace, placementPose.position, objectToPlace.transform.rotation);
    }

    void PlaceVerticalObject()
    {
        Instantiate(verticalObject, placementPose.position, verticalObject.transform.rotation);

    }

    private void UpdatePlacementIndicator()
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