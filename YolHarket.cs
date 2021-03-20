using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YolHarket : MonoBehaviour
{

    public float akıs = 2f;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.z > -250)
            transform.Translate(0, 0, -akıs * Time.deltaTime);
        else
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1498);
    }
}
