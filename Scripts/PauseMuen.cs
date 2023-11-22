using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMuen : MonoBehaviour
{
    public static bool IsPaused =false;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(IsPaused)
            {
                Resum();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resum()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        IsPaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        IsPaused = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        IsPaused = false;
        SceneManager.LoadScene(0);

    }
    public void Quit()
    {
        Application.Quit();
    }
}
