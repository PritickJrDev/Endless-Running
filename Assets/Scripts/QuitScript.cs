using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public static bool gamePaused;
    public GameObject quitObj;
    void Start()
    {
        quitObj.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    void Resume()
    {
        quitObj.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    void Pause()
    {
        quitObj.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void IQuit()
    {
        Application.Quit();
        Debug.Log("Quit presed");
    }
}
