using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
   public AudioSource Music;

   private float musicVolume = 1f;

    void Start()
    {
        Music.Play();
    }
   
    void Update()
    {
      Music.volume = musicVolume;  
    }
    public void UpdateVolume (float volume)
    {
        musicVolume = volume;
    }

    public void BacksoundToggle()
    {
        if (Music.mute == true)
        {
            Music.mute = false;
        }
        else
        {
            Music.mute = true;
        }
    }
}
