using UnityEngine;
public class MainMenuNew : MonoBehaviour
{

    public GameObject settingsScreen;
    public GameObject marketScreen;
    public GameObject mainScreen;
    public GameObject levelpanel;

    private void Start()
    {

    }

    public void LevelPanel()
    {
        levelpanel.SetActive(true);
    }

    public void LevelPanelBack()
    {
        levelpanel.SetActive(false);    
    }

    public void Settings()
    {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void set2Menu()
    {
        mainScreen.SetActive(true);
        settingsScreen.SetActive(false);
    }

    public void market()
    {
        mainScreen.SetActive(false);
        marketScreen.SetActive(true);
    }

    public void mar2Menu()
    {
        mainScreen.SetActive(true);
        marketScreen.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}