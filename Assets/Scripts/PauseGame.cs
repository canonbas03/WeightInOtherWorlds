using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public void pauseMenu()
    {
        float time = Time.timeScale;
        if(time<1)
        {
            Time.timeScale = 1;
        }
    }
}
