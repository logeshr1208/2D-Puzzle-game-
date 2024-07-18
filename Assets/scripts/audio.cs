using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class audio : MonoBehaviour
{
    public static audio Instance;
    public sound[] music, sfxmusic;
    public AudioSource musicSource,sfxsource;
  

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
       // mainmusic("theme");
    }
    public void mainmusic(string name)
    {
       sound s=Array.Find(music,x=> x.name==name);
        if (s == null)
        {
            Debug.Log("not music found");
        }
        else
        {
            musicSource.clip=s.clip;
            musicSource.Play();
        }
    }

    public void sfxplay(string name) {
        sound s = Array.Find(sfxmusic, x => x.name == name);
        if (s == null)
        {
            Debug.Log("not music found");
        }
        else
        {
            sfxsource.PlayOneShot(s.clip);
            sfxsource.Play();
        }

    }

    public void overxplay(string name)
    {
        sound s = Array.Find(sfxmusic, x => x.name == name);
        if (s == null)
        {
            Debug.Log("not music found");
        }
        else
        {
            sfxsource.PlayOneShot(s.clip);
            sfxsource.Play();
        }

    }

}
