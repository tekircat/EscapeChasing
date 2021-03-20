using UnityEngine;
using UnityEngine.UI;

public class MoneyLevel : MonoBehaviour
{
    public Text elmasText;

    void Update()
    {
        elmasText.text = PlayerPrefs.GetFloat("elmas").ToString();
    }
}
