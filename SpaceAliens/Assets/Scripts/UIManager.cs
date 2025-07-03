using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //Variables
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    //public int updateScore;
    //public Text scoreText;
    //public TextMesh scoreText;

    private void start()
    {
     // s = FindObjectOfType<Score>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();

            }
            else
            {
                PauseGame();
            }
        }
    }
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        FindObjectOfType<AudioManager>().Play("Canvas");

    }
    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        FindObjectOfType<AudioManager>().Play("Canvas");

    }
    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("Canvas");

        GameIsPaused = false;
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");

    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("Canvas");
        Application.Quit();
    }


    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("Canvas");
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("Canvas");

        SceneManager.LoadScene("MainMenu");
    }

    
}
