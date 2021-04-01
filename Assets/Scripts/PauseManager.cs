using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool paused;

    public GameObject pauseUI;
    
    void Start()
    {
        paused = false;
        pauseUI.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            Time.timeScale = 0;
            pauseUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseUI.SetActive(false);
        }
    }

    public void Unpause()
    {
        paused = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
