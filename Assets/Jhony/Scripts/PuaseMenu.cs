using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuaseMenu : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject Player;
    public string SceneName;
    private float Px;
    private float Py;
    

    public GameObject PauseMenu_ui;
    void Update()
    {
        ActivarMenu();
    }

    public void ActivarMenu()
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

    public void Resume()
    {
        PauseMenu_ui.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    } 
    public void Pause()
    {
        PauseMenu_ui.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }


    public void Save()
    {
        
        SceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelNAme", SceneName);
        PlayerPrefs.Save();
        PauseMenu_ui.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    public void Load()
    {


        SceneName = PlayerPrefs.GetString("LevelNAme", SceneName);
        SceneManager.LoadScene(SceneName);
        PlayerPrefs.Save();
        PauseMenu_ui.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;


    }

    public void GoToLobby()
    {
        SceneManager.LoadScene("lobby");
        PauseMenu_ui.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void lvl1()
    {
        SceneManager.LoadScene("Piso 1");
        PauseMenu_ui.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
