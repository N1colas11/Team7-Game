using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer Audiomixer;
    public Slider slider;

    private void Start()
    {
        slider.onValueChanged.AddListener(SetVolume);
    }
    public void SetVolume(float targetVolume)
    {
        Audiomixer.SetFloat("volume", targetVolume);
    }

    /*public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }*/
}
