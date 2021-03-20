using UnityEngine;

public class LevelMeneger : MonoBehaviour
{
    public string levelToLoad1 = "Level01";

    public SceneFader sceneFader;

    private void Start()
    {

    }

    public void StartLevel01()
    {
        sceneFader.FadeTo(levelToLoad1);
        Time.timeScale = 1f;
    }
}