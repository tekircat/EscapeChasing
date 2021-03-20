using UnityEngine;

public class DonusMainScrean : MonoBehaviour
{
    public float maxRotationAngle;
    public float period;
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
        yAxis     
    }

    void FixedUpdate()
    {
        if (rotationAxis == ROTATIONAXIS.yAxis)
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(20, (phase * maxRotationAngle)+149,0));
        }
    }
}
