using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer mainMixer;
    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
