using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonusSilah : MonoBehaviour
{
    public float maxRotationAngle;
    public float period = 1.1f;
    float myTime;
    public ROTATIONAXIS rotationAxis;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public enum ROTATIONAXIS
    {
        xAxis,
        yAxis,
        zAxis
    }

    void FixedUpdate()
    {
        if (rotationAxis == ROTATIONAXIS.xAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(phase * maxRotationAngle, 0, 0));
        }
        else if (rotationAxis == ROTATIONAXIS.yAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(0, phase * maxRotationAngle, 0));
        }
        else if (rotationAxis == ROTATIONAXIS.zAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, phase * maxRotationAngle));
        }
    }
}
