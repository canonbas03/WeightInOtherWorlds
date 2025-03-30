using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleAudio : MonoBehaviour
{
   static AudioSource m_AudioSource;
   public AudioClip[] audioClips;
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        
    }

 

    public  void PlayUI()
    {
        int selected = Random.Range(0, audioClips.Length);
        m_AudioSource.Play();
    }
}
