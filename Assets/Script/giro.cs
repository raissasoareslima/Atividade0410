using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Vector3 point;
    public Vector3 axix;
    public float angle;
    
    void Start()
    {
    }
    void Update()
    {
        transform.RotateAround(point,axix, angle);
    }
}
