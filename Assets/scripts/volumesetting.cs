using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumesetting : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private AudioMixer mixer1;
    [SerializeField] private Slider musicslider;
    [SerializeField] private Slider sfxslider;


    string Mixture = "volume";
    string sfx_new = "newsfx";
    private void Awake()
    {
        musicslider.onValueChanged.AddListener(setvolume);
        sfxslider.onValueChanged.AddListener(sfxvolume);
    }

    void setvolume(float value)
    {
        mixer.SetFloat(Mixture,Mathf.Log10(value)*20); //log based to reduce volume
    }

    void sfxvolume(float value)
    {
        mixer1.SetFloat(sfx_new, Mathf.Log10(value) * 20); //log based to reduce volume
    }
}
