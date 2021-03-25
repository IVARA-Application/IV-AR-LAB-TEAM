using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayObjectName : MonoBehaviour
{
    /*[SerializeField]
    private GameObject voltmeterName;
    [SerializeField]
    private GameObject ammeterName;
    [SerializeField]
    private GameObject RehostatName;*/

    private bool toggleVolt;
    private bool toggleAmps;
    private bool toggleReho;
    private bool toggleGlass;
    private bool togglePaper;
    private bool toggleBattery;

    private bool toggleTwoWayKey;
    private bool toggleOneWayKey;
    private bool toggleDaniellCell;
    private bool toggleLeclancheCell;





    private int keyEnabled;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleVoltmeterName(GameObject voltmeterName)
    {
        toggleVolt = !toggleVolt;
        voltmeterName.SetActive(toggleVolt);
    }
    public void ToggleAmmeterName(GameObject ammeterName)
    {
        toggleAmps = !toggleAmps;
        ammeterName.SetActive(toggleAmps);
    }
    public void ToggleRehostatName(GameObject RehostatName)
    {
        toggleReho = !toggleReho;
        RehostatName.SetActive(toggleReho);
    }
    public void ToggleGlassSlabName(GameObject glassSlabName)
    {
        toggleGlass = !toggleGlass;
        glassSlabName.SetActive(toggleGlass);
    }
    public void TogglePaperName(GameObject paperName)
    {
        togglePaper = !togglePaper;
        paperName.SetActive(togglePaper);
    }
    public void ToggleBatteryName(GameObject batteryName)
    {
        toggleBattery = !toggleBattery;
        batteryName.SetActive(toggleBattery);
    }
    public void ToggleTwoWayKeyName(GameObject twoWayKeyName)
    {
        toggleTwoWayKey = !toggleTwoWayKey;
        twoWayKeyName.SetActive(toggleTwoWayKey);
    }
    public void ToggleOneWayKeyName(GameObject oneWayKeyName)
    {
        toggleOneWayKey = !toggleOneWayKey;
        oneWayKeyName.SetActive(toggleOneWayKey);
    }
    public void ToggleDaniellName(GameObject daniellName)
    {
        toggleDaniellCell = !toggleDaniellCell;
        daniellName.SetActive(toggleDaniellCell);
    }
    public void ToggleLeclancheName(GameObject leclancheName)
    {
        toggleLeclancheCell = !toggleLeclancheCell;
        leclancheName.SetActive(toggleLeclancheCell);
    }

    public void EnableKey(GameObject key)
    {
        keyEnabled++;
        if (keyEnabled % 2 == 1)
        {
            key.GetComponent<Renderer>().material.color = Color.green;
            SeriesConnectionController.showReadings = true;
            ParallelConnectionController.showReadings = true;
            ParallelIndividualConnection.showReadings = true;
            SeriesIndividualController.showReadings = true;
            MeterBridgeResistivityResistance.showReadings = true;
            ConvertGalvanometer.showReadings = true;
            PotentiometerController.showReadings = true;
            CompareEMFController.showReadings = true;
        }
        else if (keyEnabled % 2 == 0)
        {
            key.GetComponent<Renderer>().material.color = Color.red;
            SeriesConnectionController.showReadings = false;
            ParallelConnectionController.showReadings = false;
            ParallelIndividualConnection.showReadings = false;
            SeriesIndividualController.showReadings = false;
            MeterBridgeResistivityResistance.showReadings = false;
            ConvertGalvanometer.showReadings = false;
            PotentiometerController.showReadings = false;
            CompareEMFController.showReadings = false;
        }
        
    }
    
}
