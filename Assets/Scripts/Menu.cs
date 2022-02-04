using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit is pressed");
    }
}
