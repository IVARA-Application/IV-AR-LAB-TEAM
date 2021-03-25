using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public GameObject theFloatingObject;

    public GameObject TheFloater
    {
        get { return theFloatingObject; }
    }

    private void Start()
    {
        TheFloater.SetActive(false);
    }

    private void OnMouseDown()
    {
        Clickable[] ArrOfClickables = FindObjectsOfType<Clickable>();
        foreach (var item in ArrOfClickables)
        {
            item.TheFloater.SetActive(false);
        }
        this.TheFloater.SetActive(true);
    }
}
