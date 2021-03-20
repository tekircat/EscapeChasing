using UnityEngine;
using UnityEngine.UI;

public class PlanetShopControl : MonoBehaviour
{
    public Text scoreText;
    public float elmas;
    public string[] planets;
    public float[] fiyat;
    public PlanetShop sr;

    void Update()
    {
        elmas = PlayerPrefs.GetFloat("elmas");
    }

    public void satınal(string isim)
    {
        for (int i = 0; i < planets.Length; i++)
        {
            if (planets[i] == isim)
            {
                if (elmas >= fiyat[i])
                {
                    elmas -= fiyat[i];
                    PlayerPrefs.SetString("PlanetName", planets[i]);
                    sr.anaplanet = planets[i];
                    sr.PlanetDegistir(sr.anaplanet);

                    PlayerPrefs.SetFloat("elmas", elmas);
                    scoreText.text = elmas.ToString();
                }
            }
        }
    }
}
