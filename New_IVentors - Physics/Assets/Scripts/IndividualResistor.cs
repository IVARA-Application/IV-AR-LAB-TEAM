using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualResistor : MonoBehaviour
{
    /*[SerializeField]
    private ParallelConnectionController parallelScript;*/
    
    [SerializeField]
    private ParallelIndividualConnection parallelScript;
    
    [SerializeField]
    private SeriesIndividualController seriesScript;

    [SerializeField]
    private GameObject[] keys;

    //private int currentClick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResistorValue(float value)
    {
        parallelScript.parallelResistorValue = value;
        seriesScript.seriesResistorValue = value;
    }

    public void ChangeResistorColour(int index)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            keys[i].GetComponent<Renderer>().material.color = Color.red;
            keys[index].GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
