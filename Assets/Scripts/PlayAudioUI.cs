using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class PlayAudioUI : MonoBehaviour
{
   
    public AudioSource audioSource;
    public AudioClip audioClip;
    public float delay = 1.0f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        delay = audioClip.length;
    }

  public void Timer()
    {
        audioSource.Play();
        Invoke("changeScene", delay);
    }

   public void changeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
