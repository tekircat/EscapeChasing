using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;
    public GameObject ui;
    public static int Lives;
    public static bool GameIsOver;
    public float elmas;
    private Transform target;
    private Enemy targetEnemy;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public static int Money;
    public GameObject Tank;
    public GameObject Finish;

    private void Start()
    {
    }

    void Update()
    {
        elmas = PlayerPrefs.GetFloat("elmas");
    }


    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }

    public void Continue()
    {
        if (elmas >= 5)
        {
            GameIsOver = false;
            PlayerStats.Lives = 1;
            PlayerStats.Money = PlayerStats.Money + 1;
            ui.SetActive(false);
            Time.timeScale = 1f; ;
            Tank.SetActive(true);
            Finish.SetActive(true);

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();

            elmas = elmas - 5;
            PlayerPrefs.SetFloat("elmas", elmas);
        }

    }
}
