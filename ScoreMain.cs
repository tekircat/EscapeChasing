using UnityEngine;
using UnityEngine.UI;

public class ScoreMain : MonoBehaviour
{
    public Text scoreText;
    void Update()
    {
        scoreText.text = PlayerPrefs.GetFloat("score").ToString();
    }
}