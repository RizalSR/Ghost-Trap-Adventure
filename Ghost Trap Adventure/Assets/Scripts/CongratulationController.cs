using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CongratulationController : MonoBehaviour
{
     public Text txScore;
    Text txSelamat;
    int score;
    // Start is called before the first frame update
    void Start()
    {
         score = Data.score;
        txScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit(){
        Application.Quit();
    }
}
