using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class onebyone : MonoBehaviour
{
    public AudioClip[] clip;//mainaudio play onebyone
  public AudioSource sources;
 
     
    private void Start()
    {
       sources = GetComponent<AudioSource>();
        StartCoroutine(playaudios());
    }

    IEnumerator playaudios()
    {
        yield return null;

        for (int a = 0; a < clip.Length; a++)
        {
            sources.clip = clip[a];
            sources.Play();
            while (sources.isPlaying)
            {
                yield return null;

            }
        }
       
    }

    public void StopGameOverClip()
    {
        if (sources != null && sources.isPlaying)
        {
            StartCoroutine(againplay());
            Debug.Log("Game over audio stopped");
        }
    }
    IEnumerator againplay()
    {
        sources.Stop();
        yield return new WaitForSeconds(4.0f);
        sources.Play();
    }
}
