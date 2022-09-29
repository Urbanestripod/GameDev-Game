using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame() 
    {
        SceneManager.LoadScene("Game");
        
        if (PauseMenu.GameIsPaused) 
        {
            PauseMenu.GameIsPaused = false;
        }
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }


}
