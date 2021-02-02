using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicSlider;
    public Slider sfxSlider;
    public Slider slider;
    
    private void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", 0.75f);
        slider.value = PlayerPrefs.GetFloat("Volume", 0.75f);
    }
    public void SetMusicVolume ()
    {
        float musicVolume = musicSlider.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(musicVolume) * 20);
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
    }

    public void SetSFXVolume()
    {
        float sfxVolume = sfxSlider.value;
        mixer.SetFloat("SFXVol", Mathf.Log10(sfxVolume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
    }

    public void SetVolume()
    {
        float volume = slider.value;
        mixer.SetFloat("MasterVol", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
