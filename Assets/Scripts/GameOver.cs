using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Lelio");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
