using UnityEngine;
using UnityEngine.UI;

public class Ses2 : MonoBehaviour
{

    [SerializeField] private Slider slider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("SoundVolumeLevel"))
        {
            PlayerPrefs.SetFloat("SoundVolumeLevel", 1.0f);
        }
        else
        {
            slider.value = PlayerPrefs.GetFloat("SoundVolumeLevel");
            ChangeValue();
        }
    }
    public void ChangeValue()
    {
        AudioListener.volume = slider.value;
        PlayerPrefs.SetFloat("SoundVolumeLevel", slider.value);
    }
}



