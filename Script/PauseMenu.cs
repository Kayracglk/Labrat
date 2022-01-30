using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pausemenu;
    public GameObject HealthBar;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        HealthBar.SetActive(true);
        Time.timeScale = 1f;
        GameIsPause = false;

    }

    void Pause()
    {
        pausemenu.SetActive(true);
        HealthBar.SetActive(false);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

}


