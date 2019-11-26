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
    int nyawa;
    int total;
    // Start is called before the first frame update
    void Start()
    {
         score = Data.score;
         nyawa = Data.nyawa * ShowNyawa.UbahScore;
         total = score + nyawa;
        txScore.text = total.ToString();
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
