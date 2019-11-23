using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void KeluarPermainan()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
