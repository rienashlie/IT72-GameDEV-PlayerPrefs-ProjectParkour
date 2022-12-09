using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefSFX : MonoBehaviour
{
    public AudioSource SFX, SFX1, SFX2, SFX3;
    public Slider volumeSlider;
    private float MusicVolume = 0.5f;

    void Start()
    {
        MusicVolume = PlayerPrefs.GetFloat("volumeSfx");
        SFX.volume = MusicVolume;
        SFX1.volume = MusicVolume;
        SFX2.volume = MusicVolume;
        SFX3.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    void Update()
    {
        SFX.volume = MusicVolume;
        SFX1.volume = MusicVolume;
        SFX2.volume = MusicVolume;
        SFX3.volume = MusicVolume;
        PlayerPrefs.SetFloat("volumeSfx", MusicVolume);
    }

    public void VolumeUpdater(float volume)
    {
        MusicVolume = volume;
    }
}
