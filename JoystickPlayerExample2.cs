using UnityEngine;

public class JoystickPlayerExample2 : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public float max;
    public float min;
    private Quaternion cam;

    private void Start()
    {
        cam = transform.localRotation;
    }
     void Update()
    {
        cam.y += variableJoystick.Horizontal * speed ;
        cam.y = Mathf.Clamp(cam.y, min, max);
        transform.localRotation = Quaternion.Euler(cam.x, cam.y, cam.z);

        Time.timeScale = 1;      
    }
}