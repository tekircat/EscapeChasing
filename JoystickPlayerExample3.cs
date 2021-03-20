using UnityEngine;

public class JoystickPlayerExample3 : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;

    public void Update()
    {
        transform.Translate(Vector3.right * variableJoystick.Horizontal * speed * Time.deltaTime);
    }
}