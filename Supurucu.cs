using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supurucu : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    void OnCollisionEnter(Collision collisionİnfo)
    {
        if (collisionİnfo.collider.tag == "Yol")
            Destroy(collisionİnfo.gameObject);

        if (collisionİnfo.collider.tag == "Enemy")
            Destroy(collisionİnfo.gameObject);

        if (collisionİnfo.collider.tag == "Yıldız")
            Destroy(collisionİnfo.gameObject);

    }
}