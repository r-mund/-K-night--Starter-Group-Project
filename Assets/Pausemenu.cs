using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class Pausemenu : MonoBehaviour
{   public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            { Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void LoadMain()
    {
        SceneManager.LoadScene("(k)night menu");
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
