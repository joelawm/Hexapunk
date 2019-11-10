using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("\tNew Game option has been clicked.");
        SceneManager.LoadScene(1);
        Debug.Log("\tLoaded a new game.");
    }

    public void QuitGame()
    {
        Debug.Log("\tGame has been quit.");
        Application.Quit();
    }
}
