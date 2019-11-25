using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowNyawa : MonoBehaviour
{
    public static int UbahScore = 600;
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Text>().text = "x" +Data.nyawa.ToString();

        if(Data.nyawa == 0){
            SceneManager.LoadScene("GameOver");
        }

        if(Data.score == UbahScore){
            Data.nyawa +=1;
        }
    }
}
