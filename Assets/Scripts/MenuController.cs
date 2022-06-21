using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
