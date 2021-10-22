using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    void Pause()
    {
        Time.timeScale = 0;
    }
    void UnPause()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        
    }

    void PauseFunction()
    {
        if (GameIsPaused)
        {
            UnPause();
        }
        else
        {
            Pause();
        }
    }
}
