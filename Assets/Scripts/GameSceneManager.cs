using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static void DificulityMenu()
    {
        SceneManager.LoadScene(1);
     
    }
    public static void StartEasy()
    {
        SceneManager.LoadScene(2);
    }
    public static void StartNormal()
    {
        SceneManager.LoadScene(3);
    }
    public static void StartHard()
    {
        SceneManager.LoadScene(4);
    }
    public void StartAgain()
    {
        SceneManager.LoadScene(0);
    }
    public static void QuitGame()
    {
        Application.Quit();
    }
}
