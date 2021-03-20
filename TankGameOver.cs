using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGameOver : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider İnfo)
    {

        if (İnfo.tag == "tank")
            FindObjectOfType<GameManager>().WinLevel();
    }
}
