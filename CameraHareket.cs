using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHareket : MonoBehaviour
{
    public Transform target;
    public float speed;
    float timer;

    void Start()
    {
        
    }

    void Awake()
    {
        timer = 0.0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {  
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.localEulerAngles = Vector3.MoveTowards(transform.eulerAngles, target.eulerAngles, speed * Time.deltaTime);
        }
    }
}
