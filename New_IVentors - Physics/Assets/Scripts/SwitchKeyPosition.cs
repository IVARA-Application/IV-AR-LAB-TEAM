using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchKeyPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject acKey;

    [SerializeField]
    private GameObject dcKey;

    private bool keyPosChanged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeKeyPos()
    {
        keyPosChanged = !keyPosChanged;
        acKey.SetActive(!keyPosChanged);
        dcKey.SetActive(keyPosChanged);
    }
}
