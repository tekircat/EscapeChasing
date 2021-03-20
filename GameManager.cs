using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    public GameObject Tank;
    public GameObject Finish;
    public ParticleSystem WinPart;
    public AudioSource WinSes;
    float timer;

    void Awake()
    {
        timer = 0.0f;
    }

    void Start()
    {
        GameIsOver = false;
    }

    void Update()
    {
        if (PlayerStats.Lives <= 0)
        {
            timer += Time.deltaTime;
            if (timer >= 0.3f)
                EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
        Tank.SetActive(false);
        Finish.SetActive(false);
        Time.timeScale = 1f;
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
        Tank.SetActive(false);
        WinPart.Play();
        WinSes.Play();
    }
}
