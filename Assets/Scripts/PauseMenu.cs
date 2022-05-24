using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{


    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Transform cameraHolder;

    private PlayerController playerController;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
        }
    }

    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        Resume();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //cameraHolder.enabled = true;
        GameIsPaused = false;
        playerController.enabled = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
       // cameraHolder.enabled = false;
        GameIsPaused = true;
        playerController.enabled = false;
    }



    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
