using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public Enemy movement1;

    public void PauseGame()
    {
        Time.timeScale = 0f;

        AudioListener.pause = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }
}
