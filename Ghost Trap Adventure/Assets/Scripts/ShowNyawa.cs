using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowNyawa : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Text>().text = "x" +Data.nyawa.ToString();

        if(Data.nyawa == 0){
            SceneManager.LoadScene("GameOver");
            Data.nyawa = 5;
        }

        if(Data.score == 600){
            Data.nyawa +=1;
        }
    }
}
