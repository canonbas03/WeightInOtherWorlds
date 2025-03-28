using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitApp : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  // Escape is back key in mobile by defoult
        {
            if (SceneManager.GetActiveScene().buildIndex == 0) // 0 is Main Scene
                Application.Quit();
            else { SceneManager.LoadScene(0); }
        }
    }
}

