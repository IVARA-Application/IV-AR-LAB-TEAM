using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lens : MonoBehaviour
{
    [SerializeField]
    private float focalLengthInCm = 25f;
    public float FocalLength { get { return focalLengthInCm; } }
}
