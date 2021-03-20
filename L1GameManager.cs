using UnityEngine;

public class L1GameManager : MonoBehaviour
{
    public static bool GameIsOver;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;
    public GameObject Distance;
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
            if (timer >= 0.7f)
                EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
        Distance.SetActive(false);

        Time.timeScale = 1f;
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
        Time.timeScale = 0;
    }
}
