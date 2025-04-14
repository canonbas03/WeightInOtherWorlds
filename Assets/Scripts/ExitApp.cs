using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitApp : MonoBehaviour
{
    public bool isExit = false;
    private void Update()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (Time.timeScale == 0 && activeSceneIndex == 0)
        {
            Time.timeScale = 1;
            Debug.Log("Changed back to TİME 1");
        }
        if (Input.GetKeyDown(KeyCode.Escape) || isExit)  // Escape is back key in mobile by defoult
        {
            if (activeSceneIndex == 0) // 0 is Main Scene
                Application.Quit();
            else { SceneManager.LoadScene(0); }
        }
    }
}

