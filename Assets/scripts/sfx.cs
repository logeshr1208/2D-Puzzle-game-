using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
  public  AudioSource sources;
    public AudioClip[] sfxclip;

    private void Start()
    {
        sources = GetComponent<AudioSource>();
    }

    public void sfxclips()
    {
        AudioClip sfx = sfxclip[0];
        sources.PlayOneShot(sfx);

    }

    public void swapclick()
    {
        AudioClip sfx = sfxclip[1];
        sources.PlayOneShot(sfx);
    }

    public void gameoverclip()
    {
        AudioClip sfx = sfxclip[2];
        sources.PlayOneShot(sfx);
    }
}
