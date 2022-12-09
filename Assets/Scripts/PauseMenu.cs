using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu, pauseContent, pauseSettings;
    public AudioSource audioSource;
    public AudioSource audioSourceMenu;
    public bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
                audioSourceMenu.Play();
            }
            else
            {
                PauseGame();
                audioSourceMenu.Play();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        pauseContent.SetActive(true);
        pauseSettings.SetActive(false);
        audioSource.Pause();
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        pauseSettings.SetActive(false);
        audioSource.Play(0);
        Time.timeScale = 1f;
        isPaused = false;
    }

}
