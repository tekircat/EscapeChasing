using UnityEngine;

public class PlanetShop : MonoBehaviour
{
    public string anaplanet;
    public GameObject[] planets;
    public static float elmas;
    public GameObject car1;

    void Start()
    {
        anaplanet = PlayerPrefs.GetString("PlanetName");
        PlanetDegistir(anaplanet);
    }

    public void PlanetDegistir(string planetisim)
    {
        for (int i = 0; i < planets.Length; i++)
        {

            if (planets[i].name == planetisim)
            {
                planets[i].SetActive(true);
                car1.SetActive(false);
            }
            else
            {
                planets[i].SetActive(false);

            }
        }
    }
}
