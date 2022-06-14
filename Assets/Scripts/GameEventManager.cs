using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEventManager : MonoBehaviour
{
    
    void Update()
    {

        if(GameObject.Find("Turret") == null && GameObject.Find("Tank - Enemy") == null)
        {
            Debug.Log("Win");
            SceneManager.LoadScene(5);
        }
        if (GameObject.Find("Tank") == null)
        {
            SceneManager.LoadScene(6);
            Debug.Log("Lose");
        }
    }
}
