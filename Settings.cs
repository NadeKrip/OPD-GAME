using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject SettingsMenu;
    public AudioSource SoundSource;
    public AudioClip Sound;
    public AudioSource MusicSource;

    public bool setActive = false;
    // Start is called before the first frame update
    void Start()
    {
        SettingsMenu.SetActive(setActive);
    }

    // Update is called once per frame
    public void OpenSettings()
    {
        setActive = !setActive;
        SettingsMenu.SetActive(setActive);
    }

    public void ButtonClick()
    {
        SoundSource.PlayOneShot(Sound);
    }

    public void SoundOnOff()
    {
        if(SoundSource.volume != 0f)
            SoundSource.volume = 0f;
        else
            SoundSource.volume = 1f;
    }

    public void MusicOnOff()
    {
        if (MusicSource.volume != 0f)
            MusicSource.volume = 0f;
        else
            MusicSource.volume = 1f;
    }
}
