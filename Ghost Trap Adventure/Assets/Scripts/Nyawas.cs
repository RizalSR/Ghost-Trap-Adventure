using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nyawas : MonoBehaviour
{
    public float scrollSpeed = -1.5f;
    public static Nyawas instance;
    public GameObject gameOvertext;
    public bool gameOver = false;
    public Text Score;      
    public Text Nyawa;  
    public int nyw;  
    private int score = 0;


    void Awake()
    {
        // if (instance == null)
        //     instance = this;
        // else if (instance != this)
        //     Destroy(gameObject);
    }
    void Update()
    {
    //     if (gameOver && Input.GetMouseButtonDown(0))
    //     {
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // }
    }

    // public void BirdDied()
    // {
    //     gameOvertext.SetActive(true);
    //     gameOver = true;
    // }

    public void TambahNyawa()
    {
        if (Score.text = 20)
            Score.text = 0;
            nyw =+1;
            Nyawa.text = "X" + nyw.ToString();
        }

}
