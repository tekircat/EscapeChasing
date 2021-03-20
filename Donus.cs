using UnityEngine;

public class Donus : MonoBehaviour {

    public float maxRotationAngle;
    public float period;
    float myTime;
    public ROTATIONAXIS rotationAxis;

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
	