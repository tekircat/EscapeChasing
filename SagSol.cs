using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SagSol : MonoBehaviour
{
    public float speed = 2;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x < 45)
            transform.Translate(speed * Time.deltaTime, 0, 0);
        else
            transform.position = new Vector3(transform.position.x - 90, transform.position.y, transform.position.z);
    }

}
